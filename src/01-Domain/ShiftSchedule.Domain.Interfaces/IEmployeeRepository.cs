using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Interfaces
{
<<<<<<< HEAD
    public interface IEmployeeRepository : IRepository<Employee>
=======
    public interface IEmployeeRepository : IRepositoryBase<Employee>
>>>>>>> e74678f3677175d777670a257aec6604ee2b6904
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int employeeId);

    }
}