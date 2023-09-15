using BrightAkademiApi.Data.Abstract;
using BrightAkademiApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademiApi.Data.Concrete.EfCore.Repositories
{
    public class EfCoreSettingRepository : EfCoreGenericRepository<Setting>, ISettingRepository
    {
        public EfCoreSettingRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
