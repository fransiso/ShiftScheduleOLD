using System.Collections.Generic;
<<<<<<< HEAD
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
=======
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data.ORM.EF.Repositories;

namespace ShiftSchedule.Infrastructure.Data.Repositories
{
    public class ShiftRepository : EfRepositoryBase<Shift>,IShiftRepository
    {
      
>>>>>>> e74678f3677175d777670a257aec6604ee2b6904
    }
}
