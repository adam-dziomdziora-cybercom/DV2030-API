using AutoMapper;
using DigiVisio2030.DA.Cities;
using DigiVisio2030.BL.Models;

namespace DigiVisio2030.BL.Cities
{
    public class CitiesService : ICitiesService
    {
        private readonly IMapper _mapper;
        private readonly ICitiesAdapter _citiesAdapter;

        public CitiesService(ICitiesAdapter citiesAdapter, IMapper mapper)
        {
            _citiesAdapter = citiesAdapter;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CityDTO>> GetAllCities()
        {
            var cities = await _citiesAdapter.GetAllCities();
            var citiesDTO = _mapper.Map<IEnumerable<CityDTO>>(cities);
            return citiesDTO;
        }
    }
}
