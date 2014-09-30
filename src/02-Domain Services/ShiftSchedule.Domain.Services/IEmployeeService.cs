using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
