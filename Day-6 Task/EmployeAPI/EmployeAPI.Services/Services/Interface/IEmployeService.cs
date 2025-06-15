
using EmployeAPI.Models;
using EmployeAPI.Entities.Entities;

namespace EmployeAPI.Services.Services.Interface
{
    public interface IEmployeService
    {
        void AddEmploye(Employe Employe);
        List<Employe> GetAll();
        Employe? GetEmployeById(int id);
        Task InsertEmploye(EmployeDetails employeDetails);
        EmployeDetails GetEmployeDetailsById(int id);


        //void AddEmploye(Employe Employe);
        ////List<Employe> GetAll();
        //Employe? GetEmployeById(int id);
        //Task InsertEmploye(EmployeDetails employeDetails);
        //EmployeDetails GetEmployeDetailsById(int id);

        //Task<List<EmployeDetails>> GetAllEmployeDetailsAsync(); // Added missing method definition
    }
}
