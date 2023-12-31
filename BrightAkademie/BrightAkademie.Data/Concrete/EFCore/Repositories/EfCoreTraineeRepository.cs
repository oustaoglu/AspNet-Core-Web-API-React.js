﻿using BrightAkademie.Data.Abstract;
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
    public class EfCoreTraineeRepository : EfCoreGenericRepository<Trainee>, ITraineeRepository
    {
        public EfCoreTraineeRepository(BrightAkademieContext _context) : base(_context)
        {
        }
        private BrightAkademieContext Context
        {
            get { return _dbContext as BrightAkademieContext; }
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context.Trainees.AnyAsync(x => x.Id == id.ToString());
        }

        public async Task<List<Trainee>> GetAllTrainees(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Trainees
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
