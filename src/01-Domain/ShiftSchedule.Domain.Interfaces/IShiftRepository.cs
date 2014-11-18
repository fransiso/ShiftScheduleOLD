using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;


namespace ShiftSchedule.Domain.Interfaces
{
    public interface IShiftRepository : IRepositoryBase<Shift>
    {
        //Since IPersonRepository does not define additional methods, this class's body is empty for now.

        //IEnumerable<Employee> GetEmployeesByShiftId(int shiftId);
        //void Save(Shift shift);
    }
}