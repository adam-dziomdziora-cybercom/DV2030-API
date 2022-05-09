using Dapper;
using DigiVisio2030.DA.Models;
using Microsoft.Extensions.Configuration;

namespace DigiVisio2030.DA.Cities
{
    public class CitiesAdapter : BaseAdapter, ICitiesAdapter
    {
        public CitiesAdapter(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<City>> GetAllCities()
        {
            using var conn = OpenConnection();
            var sql = CitiesQueries.GetAllCities();
            var cities = await conn.QueryAsync<City>(sql);
            return cities;
        }
    }
}
