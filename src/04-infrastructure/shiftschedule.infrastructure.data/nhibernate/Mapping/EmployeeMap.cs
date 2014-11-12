using FluentNHibernate.Mapping;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Infrastructure.Data.NHibernate.Mapping
{
    class EmployeeMap : ClassMap<Employee>
    {

        public EmployeeMap()
        {
            Table("User");
            Id(x => x.Id).Column("UserId");
            Map(x => x.FirstName).Length(100).Not.Nullable(); ;
            Map(x => x.LastName).Length(100).Not.Nullable(); ;
            Map(x => x.Email).Length(256).Unique().Not.Nullable(); ;
            Map(x => x.DateCreated).Not.Nullable();
            Map(x => x.AdminRights).Not.Nullable(); 
        }
    }
}
