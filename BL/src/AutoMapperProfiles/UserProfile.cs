using AutoMapper;
using DigiVisio2030.BL.Models;
using DigiVisio2030.DA.Models;

namespace DigiVisio2030.BL.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.CityId
                , opt => opt.Ignore());
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.City,
                opt => opt.MapFrom(src => new City { Id = src.CityId ?? -1 }));


            CreateMap<UserWithCity, UserDTO>()
                .ForMember(dest => dest.City,
                opt => opt.MapFrom(src => new City { Id = src.CityId ?? -1, Name = src.CityName ?? string.Empty }));
            CreateMap<UserDTO, UserWithCity>()
               .ForMember(dest => dest.CityId
               , opt => opt.MapFrom(src => src.City != null ? src.City.Id : -1));
        }
    }
}
