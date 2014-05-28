using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using NHibernate;

using ToDoList.Mappings;

namespace ToDoList.Helper
{
    public class NHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                           .Database(MsSqlConfiguration
                                         .MsSql2008.ConnectionString(
                                             c => c.FromAppSetting("ToDoConnectionString")).ShowSql)
                                             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ItemMap>())
                           .BuildSessionFactory();
        }
    }
}
