using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;

namespace ShiftSchedule.Infrastructure.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public void AddEmployee(Employee employee) //NTD Factory class for new object creation?
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            throw new System.NotImplementedException();
        }
    }
}
