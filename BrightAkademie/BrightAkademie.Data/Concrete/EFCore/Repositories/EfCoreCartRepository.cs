using BrightAkademie.Data.Abstract;
using BrightAkademie.Data.Concrete.EFCore.Contexts;
using BrightAkademie.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Concrete.EFCore.Repositories
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        public EfCoreCartRepository(BrightAkademieContext _context) : base(_context)
        {

        }
        BrightAkademieContext AppContext
        {
            get { return _dbContext as BrightAkademieContext; }
        }

        public async Task AddToCartAsync(string userId, int bookId, int quantity)
        {
            var cart = await GetCartByUserId(userId);
            if (cart != null)
            {
                var index = cart.CartItems.FindIndex(ci => ci.CourseId == bookId);
                if (index < 0)//Kitap daha önceden sepete eklenmemişse
                {
                    cart.CartItems.Add(new CartItem
                    {
                        CourseId = bookId,
                        CartId = cart.Id,
                        Quantity = quantity
                    });
                }
                else //Eğer kitap daha önceden sepete eklenmişse -- adedi arttıracağız
                {
                    cart.CartItems[index].Quantity += quantity;
                }

                AppContext.Carts.Update(cart);
                await AppContext.SaveChangesAsync();
            }
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {
            var result = await AppContext
                .Carts
                .Where(c => c.UserId == userId)
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Course)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
