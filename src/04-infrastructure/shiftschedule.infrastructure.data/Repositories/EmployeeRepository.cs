using System.Collections.Generic;
using NHibernate;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Domain.Interfaces.Base;
using ShiftSchedule.Infrastructure.Data.NHibernate.NHRepositories.Base;


namespace ShiftSchedule.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ISession session) : base(session)
        {
        }

    }

    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
