
using EmployeAPI.Entities.Entities;
using EmployeAPI.Models;

namespace EmployeAPI.Services.Services.Interface
{
    public interface IUserService
    {
        Task AddUser(User user);
        User? Login(string username, string password);
    }
}
