using AutoMapper;
using DigiVisio2030.BL.Models;
using DigiVisio2030.DA.Users;

namespace DigiVisio2030.BL.Users
{
    public class UsersService : IUsersService
    {
        private readonly IMapper _mapper;
        private readonly IUsersAdapter _usersAdapter;

        public UsersService(IUsersAdapter usersAdapter, IMapper mapper)
        {
            _usersAdapter = usersAdapter;
            _mapper = mapper;
        }        

        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            var users = await _usersAdapter.GetAllUsers();
            var usersDTO = _mapper.Map<IEnumerable<UserDTO>>(users);
            return usersDTO;
        }
        public async Task<IEnumerable<UserDTO>> GetAllUsersWithCities()
        {
            var usersWithCities = await _usersAdapter.GetAllUsersWithCities();
            var usersDTO = _mapper.Map<IEnumerable<UserDTO>>(usersWithCities);
            return usersDTO;
        }


    }
}
