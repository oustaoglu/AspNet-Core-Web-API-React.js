using BrightAkademie.Business.Abstract;
using BrightAkademie.Data.Concrete.EFCore.Contexts;
using BrightAkademie.Entity.Concrete.ComplexTypes;
using BrightAkademie.Entity.Concrete;
using BrightAkademie.Shared.ControllerBases;
using BrightAkademie.Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;

namespace BrightAkademie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, User")]
    public class CartController : CustomControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly ICartItemService _cartItemManager;
        private readonly BrightAkademieContext _context;
        private readonly IOrderService _orderManager;

        public CartController(UserManager<User> userManager, ICartService cartManager, ICartItemService cartItemManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _cartManager = cartManager;
            _cartItemManager = cartItemManager;
            _orderManager = orderManager;
        }

        public CartController(BrightAkademieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userId = _userManager.GetUserId(User);
            var cart = await _cartManager.GetCartByUserId(userId);
            CartDto model = new CartDto
            {
                CartId = cart.Id,
                CartItems = cart.CartItems
                    .Select(ci => new CartItemDto
                    {
                        CartItemId = ci.Id,
                        CourseId = ci.Course.Id,
                        CourseName = ci.Course.Name,
                        CourseUrl = ci.Course.Url,
                        CourseImageUrl = ci.Course.ImageUrl,
                        Price = ci.Course.Price,
                        Quantity = ci.Quantity
                    }).ToList()
            };
            return Ok();
        }

        [HttpPost("AddToCard/{id}/{quantity}")]
        public async Task<IActionResult> AddToCard(int id, int quantity)
        {
            var userId = _userManager.GetUserId(User);

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(); // Kullanıcı oturumu yoksa 401 Unauthorized yanıtı döndürebilirsiniz.
            }

            await _cartManager.AddToCart(userId, id, quantity);

            return Ok("Item added to cart.");
        }

        [HttpPost("change-quantity")]
        public async Task<IActionResult> ChangeQuantity([FromBody] CartItemDto request)
        {
            if (ModelState.IsValid)
            {
                await _cartItemManager.ChangeQuantityAsync(request.CartItemId, request.Quantity);
                return Ok("Quantity changed successfully.");
            }
            else
            {
                return BadRequest("Invalid request body.");
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var cartItem = await _cartItemManager.GetByIdAsync(id);

            if (cartItem == null)
            {
                return NotFound("Item not found in cart.");
            }
            _cartItemManager.Delete(cartItem);

            // Başarılı işlemi belirten bir yanıt döndürülebilir.
            return Ok("Item deleted from cart.");
        }

        [HttpGet("checkout")]
        public async Task<IActionResult> GetCheckoutData()
        {
            string userId = _userManager.GetUserId(User);
            User user = await _userManager.FindByIdAsync(userId);
            Cart cart = await _cartManager.GetCartByUserId(userId);

            var orderDto = new OrderDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email
            };

            var cartDto = new CartDto
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(ci => new CartItemDto
                {
                    CartItemId = ci.Id,
                    CourseId = ci.CourseId,
                    CourseName = ci.Course.Name,
                    Price = ci.Course.Price,
                    Quantity = ci.Quantity,
                    CourseImageUrl = ci.Course.ImageUrl
                }).ToList()
            };

            var response = new
            {
                Order = orderDto,
                Cart = cartDto,
                CardName = "Onur Ustaoğlu",
                CardNumber = "5890040000000016",
                ExpirationYear = "2028",
                ExpirationMonth = "10",
                Cvc = "123"
            };

            return Ok(response);
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> Checkout([FromBody] OrderDto model)
        {
            string userId = _userManager.GetUserId(User);
            Cart cart = await _cartManager.GetCartByUserId(userId);

            if (ModelState.IsValid)
            {
                model.Cart = new CartDto
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(ci => new CartItemDto
                    {
                        CartItemId = ci.Id,
                        CourseId = ci.CourseId,
                        CourseName = ci.Course.Name,
                        Price = ci.Course.Price,
                        CourseImageUrl = ci.Course.ImageUrl,
                        Quantity = ci.Quantity
                    }).ToList()
                };

                Payment payment = PaymentProcess(model);
                if (payment.Status == "success")
                {
                    await SaveOrder(model, userId);
                    _cartItemManager.ClearCart(cart.Id);

                    return Ok("Payment successful");
                }
                return BadRequest("Payment failed");
            }
            return BadRequest("Invalid model data");
        }

        [NonAction]
        private Payment PaymentProcess(OrderDto model)
        {
            #region Options
            Iyzipay.Options options = new Iyzipay.Options();
          options.ApiKey = "sandbox-zuxmQFu5ros3UaU3ThbwDWKauRYyZWBW";
            options.SecretKey = "sandbox-XUcyd9aubxKhPfCOVJhNnXqxTWFNfLvA";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            #endregion
            #region Request
            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = Convert.ToInt32(model.Cart.TotalPrice()).ToString();
            request.PaidPrice = Convert.ToInt32(model.Cart.TotalPrice()).ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = model.Cart.CartId.ToString();
            request.PaymentChannel = PaymentChannel.MOBILE_WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            #region PaymentCard
            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CardName;
            paymentCard.CardNumber = model.CardNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;
            #endregion
            #region Buyer
            Buyer buyer = new Buyer();
            buyer.Id = "12345";
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber = model.PhoneNumber;
            buyer.Email = model.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = model.Address;
            buyer.Ip = "85.34.78.112";
            buyer.City = model.City;
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;
            #endregion
            #region Addresses
            Address shippingAddress = new Address();
            shippingAddress.ContactName = model.FirstName + " " + model.LastName;
            shippingAddress.City = model.City;
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = model.Address;
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = model.FirstName + " " + model.LastName;
            billingAddress.City = model.City;
            billingAddress.Country = "Turkey";
            billingAddress.Description = model.Address;
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;
            #endregion
            #region Basket Items
            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;
            foreach (var item in model.Cart.CartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.CartItemId.ToString();
                basketItem.Name = item.CourseName;
                basketItem.Category1 = "Eğitim";
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItem.Price = Convert.ToInt32(item.Price * item.Quantity).ToString();
                basketItems.Add(basketItem);
            }
            request.BasketItems = basketItems;
            #endregion
            #endregion
            Payment payment = Payment.Create(request, options);
            return payment;
        }
        [NonAction]
        private async Task SaveOrder(OrderDto model, string userId)
        {
            Order order = new Order();
            order.UserId = userId;
            order.OrderStatus = OrderStatus.Received;
            order.OrderType = OrderType.CreditCart;
            order.OrderDate = DateTime.Now;
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.PhoneNumber = model.PhoneNumber;
            order.Email = model.Email;
            order.Address = model.Address;
            order.City = model.City;
            order.OrderItems = new List<BrightAkademie.Entity.Concrete.OrderItem>();
            BrightAkademie.Entity.Concrete.OrderItem orderItem;
            foreach (var item in model.Cart.CartItems)
            {
                orderItem = new BrightAkademie.Entity.Concrete.OrderItem();
                orderItem.Price = item.Price;
                orderItem.Quantity = item.Quantity;
                orderItem.CourseId = item.CourseId;
                order.OrderItems.Add(orderItem);
            }
            await _orderManager.CreateAsync(order);
        }
    }
}
