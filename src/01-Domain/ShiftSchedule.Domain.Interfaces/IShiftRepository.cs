using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IShiftRepository
    {
        IEnumerable<Employee> GetEmployeesByShiftId(int shiftId);
        void Save(Shift shift);
    }
}