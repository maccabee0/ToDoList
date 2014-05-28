using System;

using ToDoList.Helper;
using ToDoList.Repository;

namespace ToDoList.Con
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repo = new ToDoRepository();
            var items = repo.GetItems();

            Console.ReadKey();
        }
    }
}
