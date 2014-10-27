using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces.Base;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee,int>
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int employeeId);

    }
}