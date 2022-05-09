using DigiVisio2030.BL.Models;

namespace DigiVisio2030.BL.Users
{
    public interface IUsersService
    {
        Task<IEnumerable<UserDTO>> GetAllUsers();
        Task<IEnumerable<UserDTO>> GetAllUsersWithCities();
    }
}
