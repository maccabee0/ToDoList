using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

using ToDoList.Abstract;
using ToDoList.Helper;
using ToDoList.Models;

namespace ToDoList.Repository
{
    public class ToDoRepository : IRepository
    {
        //private readonly Configuration _configuration;
        private readonly ISessionFactory _factory;

        public ToDoRepository()
        {
            _factory = NHibernateHelper.CreateSessionFactory();
        }

        public IEnumerable<Item> GetItems()
        {
            using (var session = OpenSession())
            {
                return session.CreateQuery("select * from Items").Enumerable<Item>();
            }
        }

        public IEnumerable<Item> GetItemsByCategory(int catId)
        {
            return GetItems().Where(i => i.CategoryId == catId);
        }

        public Item GetItemById(int id)
        {
            return GetItems().FirstOrDefault(i => i.ItemId == id);
        }

        public void SaveItem(Item item)
        {
            using (var session = OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(item);
                    transaction.Commit();
                }
            }
        }

        public void DeleteItem(Item item)
        {
            using (var session = OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    session.Delete(item);
                    trans.Commit();
                }
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            using (var session = OpenSession())
            {
                return session.CreateQuery("Select * from Categories").Enumerable<Category>();
            }
        }

        public Category GetCategoryById(int id)
        {
            return GetCategories().FirstOrDefault(c => c.CategoryId == id);
        }

        public void SaveCategory(Category category)
        {
            using (var session = OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(category);
                    transaction.Commit();
                }
            }
        }

        public IEnumerable<Note> GetNotes()
        {
            using (var session = OpenSession())
            {
                var result = session.QueryOver<Note>();
                return session.CreateQuery("select * from Notes").Enumerable<Note>();
            }
        }

        public IEnumerable<Note> GetNotesByItem(int itemId)
        {
            return GetNotes().Where(n => n.ItemId == itemId);
        }

        public Note GetNoteById(int id)
        {
            return GetNotes().FirstOrDefault(n => n.NoteId == id);
        }

        public void SaveNote(Note note)
        {
            using (var session = OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(note);
                    transaction.Commit();
                }
            }
        }

        private ISession OpenSession()
        {
            return _factory.OpenSession();
        }

        private static void LoadHibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"app.config"));
            cfg.AddAssembly(typeof (Item).Assembly);
            new SchemaExport(cfg).Execute(true,true,false);
        }
    }
}
