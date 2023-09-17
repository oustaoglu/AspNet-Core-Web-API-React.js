using BrightAkademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Abstract
{
    public interface ITrainerRepository : IGenericRepository<Trainer>
    {
        Task<List<Trainer>> GetAllTrainersAsync(bool isDeleted, bool? isActive = null);
        Task CreateWithUrl(Trainer trainer);
        Task<bool> AnyAsync(int id);
    }
}
