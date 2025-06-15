using EmployeAPI.Entities.Context;
using EmployeAPI.Entities.Entities;
using EmployeAPI.Entities.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeAPI.Entities.Repositories
{
    public class EmployeRepository(EmployeDbContext employeDbContext) : IEmployeRepository
    {
        private readonly EmployeDbContext _dbContext = employeDbContext;

        public async Task InsertEmploye(EmployeDetails employeDetails)
        {
            await _dbContext.EmployeDetails.AddAsync(employeDetails);
            await _dbContext.SaveChangesAsync();
        }

        public EmployeDetails GetById(int id)
        {
            return _dbContext.EmployeDetails.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

//namespace EmployeAPI.Entities.Repositories
//{
//    public class EmployeRepository : IEmployeRepository
//    {
//        private readonly EmployeDbContext _dbContext;

//        public EmployeRepository(EmployeDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public async Task InsertEmploye(EmployeDetails employeDetails)
//        {
//            await _dbContext.EmployeDetails.AddAsync(employeDetails);
//            await _dbContext.SaveChangesAsync();
//        }

//        public EmployeDetails GetById(int id)
//        {
//            return _dbContext.EmployeDetails.FirstOrDefault(e => e.Id == id);
//        }

//        public List<EmployeDetails> GetAll()
//        {
//            return _dbContext.EmployeDetails.ToList();
//        }

//        public async Task<List<EmployeDetails>> GetAllAsync()
//        {
//            return await _dbContext.EmployeDetails.ToListAsync();
//        }
//    }
//}

