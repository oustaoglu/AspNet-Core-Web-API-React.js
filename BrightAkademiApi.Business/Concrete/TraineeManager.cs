using BrightAkademiApi.Business.Abstract;
using BrightAkademiApi.Shared.DTOs;
using BrightAkademiApi.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademiApi.Business.Concrete
{
    public class TraineeManager : ITraineeService
    {
        public Task<Response<TraineeDto>> CreateAsync(TraineeCreateDto traineeCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<TraineeDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<TraineeDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(TraineeUpdateDto traineeUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
