using BrightAkademie.Shared.DTOs;
using BrightAkademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Abstract
{
    public interface ISettingService
    {
        #region Generic
        Task<Response<SettingDto>> GetByIdAsync(int id);
        Task<Response<List<SettingDto>>> GetAllAsync();
        Task<Response<SettingDto>> CreateAsync(SettingCreateDto settingCreateDto);
        Task<Response<NoContent>> UpdateAsync(SettingUpdateDto settingUpdateDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        #endregion
    }
}
