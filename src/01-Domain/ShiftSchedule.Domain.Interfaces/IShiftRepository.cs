<<<<<<< HEAD
﻿using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces.Base;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IShiftRepository : IRepository<Shift>
=======
﻿using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;


namespace ShiftSchedule.Domain.Interfaces
{
    public interface IShiftRepository : IRepositoryBase<Shift>
>>>>>>> e74678f3677175d777670a257aec6604ee2b6904
    {
        //Since IPersonRepository does not define additional methods, this class's body is empty for now.

        //IEnumerable<Employee> GetEmployeesByShiftId(int shiftId);
        //void Save(Shift shift);
    }
}