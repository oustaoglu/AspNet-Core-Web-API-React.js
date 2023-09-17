using BrightAkademie.Shared.DTOs;
using BrightAkademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Abstract
{
    public interface ITraineeService
    {
        #region Generic
        Task<Response<TraineeDto>> GetByIdAsync(int id);
        Task<Response<List<TraineeDto>>> GetAllAsync();
        Task<Response<TraineeDto>> CreateAsync(TraineeCreateDto traineeCreateDto);
        Task<Response<NoContent>> UpdateAsync(TraineeUpdateDto traineeUpdateDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        #endregion
    }
}
