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
    }
}
