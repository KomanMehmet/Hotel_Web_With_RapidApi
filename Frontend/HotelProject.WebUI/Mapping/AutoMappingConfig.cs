using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDtos;
using HotelProject.WebUI.Dtos.LoginDtos;
using HotelProject.WebUI.Dtos.RegisterDtos;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();

            //CreateMap<LoginUserDto, AppUser>().ReverseMap();

            //CreateMap<ResultAboutDto, About>().ReverseMap();
            //CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
