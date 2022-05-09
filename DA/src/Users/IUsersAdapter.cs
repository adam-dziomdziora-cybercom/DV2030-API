using DigiVisio2030.DA.Models;

namespace DigiVisio2030.DA.Users
{
    public interface IUsersAdapter
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<IEnumerable<UserWithCity>> GetAllUsersWithCities();
    }
}
