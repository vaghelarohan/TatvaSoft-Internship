using EmployeAPI.Entities.Repositories.Interface;
using EmployeAPI.Models;
using EmployeAPI.Entities.Entities;
using EmployeAPI.Services.Services.Interface;

namespace EmployeAPI.Services
{
    // For CRUD on books
    public class EmployeService : IEmployeService
    {
        private readonly List<Employe> _employes;
        private readonly IEmployeRepository _employeRepository;

        public EmployeService(IEmployeRepository employeRepository)
        {
            _employeRepository = employeRepository;
            _employes = new List<Employe>();
        }

        // To Add Book
        public void AddEmploye(Employe employe)
        {
            _employes.Add(employe);
        }

        //To Get All Books
        public List<Employe> GetAll()
        {
            return _employes;
        }

        // To Get Single Book
        public Employe? GetEmployeById(int id)
        {
            return _employes.Find(x => x.Id == id);
        }

        public async Task InsertEmploye(EmployeDetails employeDetails)
        {
            await _employeRepository.InsertEmploye(employeDetails);
        }


        public EmployeDetails GetEmployeDetailsById(int id)
        {
            return _employeRepository.GetById(id);
        }



        // To Update Book
        // To Delete Book
    }
}







//namespace EmployeAPI.Services
//{
//    // For CRUD on books
//    public class EmployeService : IEmployeService
//    {
//        private List<Employe> _employes;
//        private readonly IEmployeRepository _employeRepository;

//        public EmployeService(IEmployeRepository employeRepository)
//        {
//            _employeRepository = employeRepository;
//            _employes = new List<Employe>();
//        }

//        // To Add Book
//        public void AddEmploye(Employe employe)
//        {
//            _employes.Add(employe);
//        }

//        //// To Get All Books
//        //public List<Employe> GetAll()
//        //{
//        //    return _employes;
//        //}

//        // To Get Single Book
//        public Employe? GetEmployeById(int id)
//        {
//            return _employes.Find(x => x.Id == id);
//        }

//        public async Task InsertEmploye(EmployeDetails employeDetails)
//        {
//            await _employeRepository.InsertEmploye(employeDetails);
//        }


//        public EmployeDetails GetEmployeDetailsById(int id)
//        {
//            return _employeRepository.GetById(id);
//        }

//        Task<List<EmployeDetails>> IEmployeService.GetAllEmployeDetailsAsync()
//        {
//            throw new NotImplementedException();
//        }

//        //public List<EmployeDetails> GetAll()
//        //{
//        //    return _employeRepository.GetAll();
//        //}

//        //public async Task<List<EmployeDetails>> GetAllAsync()
//        //{
//        //    return await _employeRepository.GetAllAsync();
//        //}

//        // To Update Book
//        // To Delete Book
//    }
//}

//public interface IEmployeRepository
//{
//    Task InsertEmploye(EmployeDetails employeDetails);
//    EmployeDetails GetById(int id);
//    List<EmployeDetails> GetAll(); // Add this line
//    Task<List<EmployeDetails>> GetAllAsync();
//}
