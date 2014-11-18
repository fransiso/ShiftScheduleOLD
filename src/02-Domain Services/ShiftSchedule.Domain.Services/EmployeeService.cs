using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using System.Linq;

namespace ShiftSchedule.Domain.Services
{
    public class EmployeeService : ServiceBase<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

    }
}
