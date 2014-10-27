using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data.NHibernate.Repositories.Base;

namespace ShiftSchedule.Infrastructure.Data.NHibernate.Repositories
{
    public class ShiftRepository : NhRepositoryBase<Shift,int>,IShiftRepository
    {
        public IEnumerable<Employee> GetEmployeesByShiftId(int shiftId)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Shift shift)
        {
            throw new System.NotImplementedException();
        }
    }
}
