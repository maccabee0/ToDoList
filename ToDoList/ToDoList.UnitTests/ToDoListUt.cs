using NUnit.Framework;

namespace ToDoList.UnitTests
{
    [TestFixture]
    public class ToDoListUt
    {

        [Test]
        public void TestConnection()
        {
            var config = new NHibernate.Cfg.Configuration();
            Assert.IsNotNull(config);
        }

        [Test]
        public void TestRepo()
        {
            var repo = new Repository.ToDoRepository();
            Assert.IsNotNull(repo);
        }

        [Test]
        public void TestItems()
        {
            var items = new Repository.ToDoRepository().GetItems();
            Assert.IsNotNull(items);
        }

        [Test]
        public void TestCategories()
        {
            var cats = new Repository.ToDoRepository().GetCategories();
            Assert.IsNotNull(cats);
        }
        
        [Test]
        public void TestNotes()
        {
            var notes = new Repository.ToDoRepository().GetNotes();
            Assert.IsNotNull(notes);
        }
    }
}
