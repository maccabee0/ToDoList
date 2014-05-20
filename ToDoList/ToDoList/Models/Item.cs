using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Task { get; set; }
        public int CategoryId { get; set; }
        public List<Note> Notes { get; set; }
        public Category Category { get; set; }
    }
}
