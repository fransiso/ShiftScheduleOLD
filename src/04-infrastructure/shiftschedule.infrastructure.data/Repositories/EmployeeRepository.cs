using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data.ORM.EF.Repositories;



namespace ShiftSchedule.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : EfRepositoryBase<Employee>, IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            throw new System.NotImplementedException();
        }
    }
}
