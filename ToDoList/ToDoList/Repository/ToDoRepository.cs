using System.Collections.Generic;

using NHibernate;
using NHibernate.Cfg;

using ToDoList.Models;

namespace ToDoList.Repository
{
    public class ToDoRepository
    {
        private readonly Configuration _configuration;
        private readonly ISessionFactory _factory;

        public ToDoRepository()
        {
            _configuration=new Configuration();
            _configuration.AddAssembly("ToDoList");
            _factory = _configuration.BuildSessionFactory();
        }

        public IEnumerable<Item> GetItems()
        {
            var session = _factory.OpenSession();
            return session.CreateQuery("select * from Items").Enumerable<Item>();
        }

        public IEnumerable<Category> GetCategories()
        {
            var session = _factory.OpenSession();
            return session.CreateQuery("Select * from Categories").Enumerable<Category>();
        }

        public IEnumerable<Note> GetNotes()
        {
            var session = _factory.OpenSession();
            return session.CreateQuery("select * from Notes").Enumerable<Note>();
        }
    }
}
