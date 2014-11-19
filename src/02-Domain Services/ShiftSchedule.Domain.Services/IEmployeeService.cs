using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Services
{
    public interface IEmployeeService : IServiceBase<Employee>
    {
<<<<<<< HEAD
        List<Employee> GetEmployees();
        void CreateEmployee(Employee person);

        void UpdateEmployee(Employee person);

        void DeleteEmployee(Employee person);
=======
       
>>>>>>> e74678f3677175d777670a257aec6604ee2b6904
    }
}
