using System;

using ToDoList.Repository;

namespace ToDoList.Con
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repo = new ToDoRepository();
            var items = repo.GetItems();
            foreach (var item in items)
            {
                Console.WriteLine(item.ItemId + " / " + item.Task + " / " + item.Category.CategoryString);
            }

            Console.ReadKey();
        }
    }
}
