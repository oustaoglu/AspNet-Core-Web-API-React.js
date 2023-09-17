using AutoMapper;
using BrightAkademie.Entity.Concrete;
using BrightAkademie.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Mapping
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();

            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();

            CreateMap<Setting, SettingDto>().ReverseMap();
            CreateMap<Setting, SettingCreateDto>().ReverseMap();
            CreateMap<Setting, SettingUpdateDto>().ReverseMap();

            CreateMap<Trainee, TraineeDto>().ReverseMap();
            CreateMap<Trainee, TraineeCreateDto>().ReverseMap();
            CreateMap<Trainee, TraineeUpdateDto>().ReverseMap();

            CreateMap<Trainer, TrainerDto>().ReverseMap();
            CreateMap<Trainer, TrainerCreateDto>().ReverseMap();
            CreateMap<Trainer, TrainerUpdateDto>().ReverseMap();
        }
    }
}
