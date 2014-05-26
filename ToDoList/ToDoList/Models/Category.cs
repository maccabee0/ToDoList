using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryString { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
