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
    public class TraineeManager : ITraineeService
    {
        private readonly ITraineeRepository _traineeRepository;
        private readonly IMapper _mapper;

        public TraineeManager(ITraineeRepository traineeRepository, IMapper mapper)
        {
            _traineeRepository = traineeRepository;
            _mapper = mapper;
        }

        public async Task<Response<TraineeDto>> CreateAsync(TraineeCreateDto traineeCreateDto)
        {
            var newTrainee = _mapper.Map<Trainee>(traineeCreateDto);
            newTrainee.CreatedDate = DateTime.Now;
            await _traineeRepository.CreateAsync(newTrainee);
            var traineeDto = _mapper.Map<TraineeDto>(newTrainee);
            return Response<TraineeDto>.Success(traineeDto, 201);

        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedTrainee = await _traineeRepository.GetByIdAsync(id);
            if (deletedTrainee == null)
            {
                return Response<NoContent>.Fail("Böyle bir öğrenci yok.", 401);
            }
            _traineeRepository.Delete(deletedTrainee);
            return Response<NoContent>.Success(203);
        }

        public async Task<Response<List<TraineeDto>>> GetAllAsync()
        {
            var traineeList = await _traineeRepository.GetAllAsync();
            var traineeDtoList = _mapper.Map<List<TraineeDto>>(traineeList);
            if (traineeList.Any())
            {
                return Response<List<TraineeDto>>.Success(traineeDtoList, 200);
            }
            return Response<List<TraineeDto>>.Fail("Hiç öğrenci yok", 401);
        }

        public async Task<Response<TraineeDto>> GetByIdAsync(int id)
        {
            var trainee = await _traineeRepository.GetByIdAsync(id);
            var traineeDto = _mapper.Map<TraineeDto>(trainee);
            if (trainee != null)
            {
                return Response<TraineeDto>.Success(traineeDto, 201);
            }
            return Response<TraineeDto>.Fail("Böyle bir öğrenci yok", 401);
        }

        public async Task<Response<NoContent>> UpdateAsync(TraineeUpdateDto traineeUpdateDto)
        {
            var isThere = await _traineeRepository.AnyAsync(traineeUpdateDto.Id);
            if (isThere)
            {
                var trainee = _mapper.Map<Trainee>(traineeUpdateDto);
                trainee.ModifiedDate = DateTime.Now;
                _traineeRepository.Update(trainee);
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Böyle bir öğrenci yok", 401);
        }
    }
}
