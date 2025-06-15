
using EmployeAPI.Entities.Entities;

namespace EmployeAPI.Entities.Repositories.Interface
{
    public interface IEmployeRepository
    {
   
        Task InsertEmploye(EmployeDetails employeDetails);
        EmployeDetails GetById(int id);
    }
}
