using AutoMapper;
using LenaProject.Dto.AppUserDtos;
using LenaProject.Dto.FormsDetailsDto;
using LenaProject.Dto.FormsDtos;
using LenaProject.Entites.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI.Map
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Forms, FormsListDto>();
            CreateMap<FormsListDto, Forms>();
            CreateMap<Forms, FormsAddDto>();
            CreateMap<FormsAddDto, Forms>();

            CreateMap<FormsDetails, FormsDetailAddDto>();
            CreateMap<FormsDetailAddDto, FormsDetails>();



            CreateMap<AppUser, AppUserRegisterDto>();
            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();
            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUserListDto, AppUser>();
            CreateMap<AppUser, AppUserListDto>();

        }

    }
}
