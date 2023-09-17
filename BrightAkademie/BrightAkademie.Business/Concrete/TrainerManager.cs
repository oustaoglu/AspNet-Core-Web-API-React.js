using BrightAkademie.Business.Abstract;
using BrightAkademie.Entity.Concrete;
using BrightAkademie.Shared.DTOs;
using BrightAkademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Concrete
{
    public class TrainerManager : ITrainerService
    {
        public Task<Response<TrainerDto>> CreateAsync(TrainerCreateDto trainerCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateWithUrl(Trainer trainer)
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

        public Task<List<Trainer>> GetAllTrainersAsync(bool isDeleted, bool? isActive = null)
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
