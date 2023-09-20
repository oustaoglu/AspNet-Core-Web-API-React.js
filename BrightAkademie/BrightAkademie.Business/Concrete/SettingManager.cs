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
    public class SettingManager : ISettingService
    {
        private readonly ISettingRepository _settingRepository;
        private readonly IMapper _mapper;

        public SettingManager(ISettingRepository settingRepository, IMapper mapper)
        {
            _settingRepository = settingRepository;
            _mapper = mapper;
        }

        public async Task<Response<SettingDto>> CreateAsync(SettingCreateDto settingCreateDto)
        {
            var newSetting = _mapper.Map<Setting>(settingCreateDto);
            newSetting.CreatedDate = DateTime.Now;
            await _settingRepository.CreateAsync(newSetting);

            return Response<SettingDto>.Success(_mapper.Map<SettingDto>(newSetting), 201);
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedSetting = await _settingRepository.GetByIdAsync(id);
            if (deletedSetting == null)
            {
                return Response<NoContent>.Fail("Böyle bir ayar yok", 401);
            }
            _settingRepository.Delete(deletedSetting);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<List<SettingDto>>> GetAllAsync()
        {
            var settingList = await _settingRepository.GetAllAsync();
            if (settingList == null)
            {
                return Response<List<SettingDto>>.Fail("Hiç ayar bulunamadı", 301);
            }
            var settingDtoList = _mapper.Map<List<SettingDto>>(settingList);
            return Response<List<SettingDto>>.Success(settingDtoList, 201);
        }

        public async Task<Response<SettingDto>> GetByIdAsync(int id)
        {
            var setting = await _settingRepository.GetByIdAsync(id);
            if (setting == null)
            {
                return Response<SettingDto>.Fail("Böyle bir ayar yok", 301);
            }
            var settingDto = _mapper.Map<SettingDto>(setting);
            return Response<SettingDto>.Success(settingDto, 200);
        }

        public async Task<Response<NoContent>> UpdateAsync(SettingUpdateDto settingUpdateDto)
        {
            var isThere = await _settingRepository.AnyAsync(settingUpdateDto.Id);
            if (isThere)
            {
                var setting = _mapper.Map<Setting>(settingUpdateDto);
                setting.ModifiedDate = DateTime.Now;
                _settingRepository.Update(setting);
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Böyle bir ayar yok", 401);
        }
    }
}
