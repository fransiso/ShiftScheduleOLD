using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data.NHibernate.Repositories.Base;

namespace ShiftSchedule.Infrastructure.Data.NHibernate.Repositories
{
    public class EmployeeRepository : NhRepositoryBase<Employee,int>, IEmployeeRepository
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
