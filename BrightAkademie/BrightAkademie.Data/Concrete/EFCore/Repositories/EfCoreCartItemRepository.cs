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
    public class EfCoreCartItemRepository : EfCoreGenericRepository<CartItem>, ICartItemRepository
    {
        public EfCoreCartItemRepository(BrightAkademieContext _context) : base(_context)
        {

        }
        BrightAkademieContext AppContext
        {
            get { return _dbContext as BrightAkademieContext; }
        }
        public async Task ChangeQuantityAsync(CartItem item, int quantity)
        {
            item.Quantity = quantity;
            AppContext.CartItems.Update(item);
            await AppContext.SaveChangesAsync();
        }

        public void ClearCart(int cartId)
        {
            AppContext
                .CartItems
                .Where(ci => ci.CartId == cartId)
                .ExecuteDelete();
        }
    }
}
