using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using ShiftSchedule.Infrastructure.Data.NHibernate.Mapping;

namespace ShiftSchedule.Infrastructure.Data
{
    public class ConnectionHelper
    {
        public static ISessionFactory BuildSessionFactory(string ConnString)
        {
            return GetConfiguration(ConnString).BuildSessionFactory();
        }

        public static FluentConfiguration GetConfiguration(string ConnString)
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey(ConnString)))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>());
        }
    }
}
