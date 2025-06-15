using EmployeAPI.Entities.Entities;

namespace EmployeAPI.Entities.Repositories.Interface

{
    public interface IUserRepository
    {
        Task AddUser(User user);

        User? Login(string username, string password);
    }
}
