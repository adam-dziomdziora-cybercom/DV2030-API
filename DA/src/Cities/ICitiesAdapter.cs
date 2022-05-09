using DigiVisio2030.DA.Models;

namespace DigiVisio2030.DA.Cities
{
    public interface ICitiesAdapter
    {
        Task<IEnumerable<City>> GetAllCities();
    }
}
