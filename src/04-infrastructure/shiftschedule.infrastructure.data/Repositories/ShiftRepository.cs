using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data.ORM.EF.Repositories;

namespace ShiftSchedule.Infrastructure.Data.Repositories
{
    public class ShiftRepository : EfRepositoryBase<Shift>,IShiftRepository
    {
      
    }
}
