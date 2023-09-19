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
    public class EfCoreTrainerRepository : EfCoreGenericRepository<Trainer>, ITrainerRepository
    {
        public EfCoreTrainerRepository(BrightAkademieContext _context) : base(_context)
        {
        }
        private BrightAkademieContext Context
        {
            get { return _dbContext as BrightAkademieContext; }
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context.Trainers.AnyAsync(x => x.Id == id);
        }

        public async Task CreateWithUrl(Trainer trainer)
        {
            await Context.Trainers.AddAsync(trainer);
            await Context.SaveChangesAsync();
            trainer.Url = trainer.Url + "-" + trainer.Id;
            await Context.SaveChangesAsync();
        }

        public async Task<List<Trainer>> GetAllTrainersAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Trainers
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
