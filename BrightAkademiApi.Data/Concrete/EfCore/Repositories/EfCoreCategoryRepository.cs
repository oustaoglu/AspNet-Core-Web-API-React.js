using BrightAkademiApi.Data.Abstract;
using BrightAkademiApi.Data.Concrete.EFCore.Contexts;
using BrightAkademiApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademiApi.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(BrightAkademiApiContext _context) : base(_context)
        {
        }
        private BrightAkademiApiContext Context
        {
            get { return _dbContext as BrightAkademiApiContext; }
        }
        public async Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Categories
                .Where(c => c.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
