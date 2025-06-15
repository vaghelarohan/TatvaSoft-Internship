using EmployeAPI.Entities.Entities;
using Microsoft.EntityFrameworkCore;
namespace EmployeAPI.Entities.Context
{
   

        public class EmployeDbContext(DbContextOptions<EmployeDbContext> options) : DbContext(options)
        {
            public DbSet<EmployeDetails> EmployeDetails { get; set; }
        public DbSet<User> Users { get; set; }

    }
    
}
