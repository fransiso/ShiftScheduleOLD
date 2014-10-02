using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeService _repository;

        public EmployeeService(IEmployeeService repository)
        {
            _repository = repository;
        }

        public List<Employee> GetEmployees()
        {
			return _repository.GetEmployees();
        }
    }
}
