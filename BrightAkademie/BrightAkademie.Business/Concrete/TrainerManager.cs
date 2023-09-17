using AutoMapper;
using BrightAkademie.Business.Abstract;
using BrightAkademie.Data.Abstract;
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
        private readonly ITrainerRepository _trainerRepository;
        private readonly IMapper _mapper;

        public TrainerManager(ITrainerRepository trainerRepository, IMapper mapper)
        {
            _trainerRepository = trainerRepository;
            _mapper = mapper;
        }

        public async Task<Response<TrainerDto>> CreateAsync(TrainerCreateDto trainerCreateDto)
        {
            var newtrainer = _mapper.Map<Trainer>(trainerCreateDto);
            newtrainer.CreatedDate = DateTime.Now;
            await _trainerRepository.CreateAsync(newtrainer);
            var TrainerDto = _mapper.Map<TrainerDto>(newtrainer);
            return Response<TrainerDto>.Success(TrainerDto, 201);

        }

        public async Task CreateWithUrl(Trainer trainer)
        {
            await _trainerRepository.CreateWithUrl(trainer);
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedtrainer = await _trainerRepository.GetByIdAsync(id);
            if (deletedtrainer == null)
            {
                return Response<NoContent>.Fail("Böyle bir Öğrenci yok.", 401);
            }
            _trainerRepository.Delete(deletedtrainer);
            return Response<NoContent>.Success(203);
        }

        public async Task<Response<List<TrainerDto>>> GetAllAsync()
        {
            var trainerList = await _trainerRepository.GetAllAsync();
            var TrainerDtoList = _mapper.Map<List<TrainerDto>>(trainerList);
            if (trainerList.Any())
            {
                return Response<List<TrainerDto>>.Success(TrainerDtoList, 200);
            }
            return Response<List<TrainerDto>>.Fail("Hiç eğitmen yok", 401);
        }

        public async Task<List<Trainer>> GetAllTrainersAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _trainerRepository.GetAllTrainersAsync(isDeleted, isActive);
            return result;
        }

        public async Task<Response<TrainerDto>> GetByIdAsync(int id)
        {
            var trainer = await _trainerRepository.GetByIdAsync(id);
            var TrainerDto = _mapper.Map<TrainerDto>(trainer);
            if (trainer != null)
            {
                return Response<TrainerDto>.Success(TrainerDto, 201);
            }
            return Response<TrainerDto>.Fail("Böyle bir eğitmen yok", 401);
        }

        public async Task<Response<NoContent>> UpdateAsync(TrainerUpdateDto trainerUpdateDto)
        {
            var isThere = await _trainerRepository.AnyAsync(trainerUpdateDto.Id);
            if (isThere)
            {
                var trainer = _mapper.Map<Trainer>(trainerUpdateDto);
                trainer.ModifiedDate = DateTime.Now;
                _trainerRepository.Update(trainer);
                return Response<NoContent>.Success(204);
            }

            return Response<NoContent>.Fail("Böyle bir eğitmen yok", 401);
        }
    }
}
