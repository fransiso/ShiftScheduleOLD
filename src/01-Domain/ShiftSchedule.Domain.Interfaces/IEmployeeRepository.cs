using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int employeeId);

    }
}