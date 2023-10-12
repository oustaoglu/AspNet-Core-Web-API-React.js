using BrightAkademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Abstract
{
    public interface ICartService
    {
        Task InitializeCart(string userId);
        Task AddToCart(string userId, int bookId, int quantity);
        Task<Cart> GetByIdAsync(int id);
        Task<Cart> GetCartByUserId(string id);
        Task DeleteAsync(string userId);
    }
}
