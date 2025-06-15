using EmployeAPI.Entities.Entities;
using EmployeAPI.Entities.Migrations;
using EmployeAPI.Entities.Repositories.Interface;
using EmployeAPI.Models;
using EmployeAPI.Services.Services.Interface;

namespace EmployeAPI.Services
{
    // For CRUD on books
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // To Add User
        public async Task AddUser(Entities.Entities.User user)
        {
            await this._userRepository.AddUser(user);
        }

        public Entities.Entities.User? Login(string username, string password)
        {
            return this._userRepository.Login(username, password);
        }
    }
}
