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
    public class CourseManager : ICourseService
    {
        public Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<CourseDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
