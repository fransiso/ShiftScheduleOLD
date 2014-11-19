using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using System.Linq;

namespace ShiftSchedule.Domain.Services
{
    public class EmployeeService : ServiceBase<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
<<<<<<< HEAD
=======
            : base(repository)
>>>>>>> e74678f3677175d777670a257aec6604ee2b6904
        {
            _repository = repository;
        }

<<<<<<< HEAD
        /* Used UnitOfWork attribute, because GetAll method returns IQueryable<Person>, it does not fetches records from database. 
         * No database operation is performed until ToList(). Thus, we need to control connection open/close in this method using UnitOfWork. */
        public List<Employee> GetEmployees()
        {
            return _repository.GetAll().OrderBy(employee => employee.FirstName).ToList();
        }

        public void CreateEmployee(Employee employee)
        {
            /* Not used UnitOfWork attribute, because this method only calls one repository method and repoository can manage it's connection/transaction. */
            _repository.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            /* Not used UnitOfWork attribute, because this method only calls one repository method and repoository can manage it's connection/transaction. */
            _repository.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            /* Used UnitOfWork attribute, because we use different repositories and all operations must be transactional. */
            _repository.Delete(employee);
        }
=======
>>>>>>> e74678f3677175d777670a257aec6604ee2b6904
    }
}
