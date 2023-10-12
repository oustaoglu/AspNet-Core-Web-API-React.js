using BrightAkademie.Business.Abstract;
using BrightAkademie.Data.Abstract;
using BrightAkademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task AddToCart(string userId, int bookId, int quantity)
        {
            await _cartRepository.AddToCartAsync(userId, bookId, quantity);
        }

        public async Task DeleteAsync(string userId)
        {
            var cart = await GetCartByUserId(userId);
            _cartRepository.Delete(cart);
        }

        public Task<Cart> GetByIdAsync(int id)
        {
            return _cartRepository.GetByIdAsync(id);
        }

        public async Task<Cart> GetCartByUserId(string id)
        {
            return await _cartRepository.GetCartByUserId(id);
        }

        public async Task InitializeCart(string userId)
        {
            //Cart cart = new Cart { UserId = userId };
            //await _cartRepository.CreateAsync(cart);
            await _cartRepository.CreateAsync(new Cart { UserId = userId });
        }
    }
}
