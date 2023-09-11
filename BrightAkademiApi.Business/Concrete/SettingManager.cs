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
    public class SettingManager : ISettingService
    {
        public Task<Response<SettingDto>> CreateAsync(SettingCreateDto settingCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<SettingDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<SettingDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(SettingUpdateDto settingUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
