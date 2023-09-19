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
    public class EfCoreSettingRepository : EfCoreGenericRepository<Setting>, ISettingRepository
    {
        public EfCoreSettingRepository(BrightAkademieContext _context) : base(_context)
        {
        }
        private BrightAkademieContext Context
        {
            get { return _dbContext as BrightAkademieContext; }
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context
                .Settings
                .AnyAsync(x => x.Id == id);
        }

        public async Task<List<Setting>> GetAllSettings(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Settings
                .Where(a => a.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(a => a.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
