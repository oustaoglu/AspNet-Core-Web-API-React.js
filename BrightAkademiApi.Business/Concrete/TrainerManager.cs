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
    public class TrainerManager : ITrainerService
    {
        public Task<Response<TrainerDto>> CreateAsync(TrainerCreateDto trainerCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<TrainerDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<TrainerDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(TrainerUpdateDto trainerUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
