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
    public class EfCoreTraineeRepository : EfCoreGenericRepository<Trainee>, ITraineeRepository
    {
        public EfCoreTraineeRepository(BrightAkademiApiContext _context) : base(_context)
        {
        }
        private BrightAkademiApiContext Context
        {
            get { return _dbContext as BrightAkademiApiContext; }
        }
        public async Task<bool> AnyAsync(int id)
        {
            return await Context.Trainers.AnyAsync(x => x.Id == id);
        }

        public async Task<List<Trainee>> GetAllTrainees(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Traines
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
