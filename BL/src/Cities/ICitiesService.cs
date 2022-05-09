using DigiVisio2030.BL.Models;

namespace DigiVisio2030.BL.Cities
{
    public interface ICitiesService
    {
        Task<IEnumerable<CityDTO>> GetAllCities();
    }
}
