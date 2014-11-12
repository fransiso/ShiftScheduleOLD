using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces.Base;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IShiftRepository : IRepository<Shift>
    {
        //Since IPersonRepository does not define additional methods, this class's body is empty for now.

        //IEnumerable<Employee> GetEmployeesByShiftId(int shiftId);
        //void Save(Shift shift);
    }
}