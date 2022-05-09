using Dapper;
using DigiVisio2030.DA.Models;
using Microsoft.Extensions.Configuration;

namespace DigiVisio2030.DA.Users
{
    public class UsersAdapter : BaseAdapter, IUsersAdapter
    {
        public UsersAdapter(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            using var conn = OpenConnection();
            var sql = UsersQueries.GetAllUsers();
            var users = await conn.QueryAsync<User>(sql);
            return users;
        }

        public async Task<IEnumerable<UserWithCity>> GetAllUsersWithCities()
        {
            using var conn = OpenConnection();
            var sql = UsersQueries.GetAllUsersWithCities();


            static UserWithCity mapUserWithCity(User user, City city)
            {
                var userWithCity = new UserWithCity
                {
                    Id = user.Id,
                    CityId = city.Id,
                    CityName = city.Name,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                };

                return userWithCity;
            }
            var usersWithCity = await conn.QueryAsync(sql, (Func<User, City, UserWithCity>)mapUserWithCity);
            return usersWithCity;
        }
    }
}
