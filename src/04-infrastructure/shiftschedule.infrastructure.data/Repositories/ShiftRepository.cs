using System.Collections.Generic;
using NHibernate;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Domain.Interfaces.Base;
using ShiftSchedule.Infrastructure.Data.NHibernate.NHRepositories;
using ShiftSchedule.Infrastructure.Data.NHibernate.NHRepositories.Base;

namespace ShiftSchedule.Infrastructure.Data.Repositories
{
    public class ShiftRepository : RepositoryBase<Shift>,IShiftRepository
    {
        public ShiftRepository(ISession session)
            : base(session)
        {
        }

    }
    public interface IShiftRepository : IRepository<Shift>
    {
    }
}
