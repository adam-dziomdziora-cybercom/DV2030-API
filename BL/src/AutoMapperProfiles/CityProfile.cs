using AutoMapper;
using DigiVisio2030.BL.Models;
using DigiVisio2030.DA.Models;

namespace DigiVisio2030.BL.AutoMapperProfiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<CityDTO, City>();
            CreateMap<City, CityDTO>();
        }
    }
}
