using EmployeAPI.Entities.Context;
using EmployeAPI.Entities.Entities;
using EmployeAPI.Entities.Repositories.Interface;

namespace EmployeAPI.Entities.Repositories
{
    public class UserRepository(EmployeDbContext employeDbContext): IUserRepository
    {
        private readonly EmployeDbContext _dbContext = employeDbContext;

        public async Task AddUser(User user)
        {
            await _dbContext.Users.AddAsync(user);  
            await _dbContext.SaveChangesAsync();
        }

        public User? Login(string username, string password)
        {
            return _dbContext.Users.Where(x => x.Email == username && x.Password == password).FirstOrDefault();
        }
    }
}
