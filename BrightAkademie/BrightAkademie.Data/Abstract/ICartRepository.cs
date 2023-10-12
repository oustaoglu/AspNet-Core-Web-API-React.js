using BrightAkademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Abstract
{
    public interface ICartRepository : IGenericRepository<Cart> 
    {
        Task<Cart> GetCartByUserId(string userId);
        Task AddToCartAsync(string userId, int bookId, int quantity);
    }
}
