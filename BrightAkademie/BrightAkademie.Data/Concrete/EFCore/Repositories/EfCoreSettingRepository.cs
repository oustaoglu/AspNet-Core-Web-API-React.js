using BrightAkademie.Data.Abstract;
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
        public EfCoreSettingRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
