using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using NHibernate;
using NHibernate.Cfg;

using ToDoList.Mappings;

namespace ToDoList.Helper
{
    public class NHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            var factory = Fluently.Configure()
                           .Database(MsSqlConfiguration
                                         .MsSql2008.ConnectionString(
                                             c => c.FromConnectionStringWithKey("ToDoConnectionString")).ShowSql)
                                             .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ItemMap>())
                           .BuildSessionFactory();
            return factory;
        }

        public static void BuildSchema(Configuration config)
        {
            
        }
    }
}
