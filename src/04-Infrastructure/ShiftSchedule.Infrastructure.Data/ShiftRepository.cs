using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;

namespace ShiftSchedule.Infrastructure.Data
{
    public class ShiftRepository : IShiftRepository
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
