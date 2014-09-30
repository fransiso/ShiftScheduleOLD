using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}