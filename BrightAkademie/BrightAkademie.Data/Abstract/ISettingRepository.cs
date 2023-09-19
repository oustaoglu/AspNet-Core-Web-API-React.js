using BrightAkademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Abstract
{
    public interface ISettingRepository : IGenericRepository<Setting>
    {
        Task<List<Setting>> GetAllSettings(bool isDeleted, bool? isActive = null);
        Task<bool> AnyAsync(int id);


    }
}
