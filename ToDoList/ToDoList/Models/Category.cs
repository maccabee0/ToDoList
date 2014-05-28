﻿using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryString { get; set; }
        public virtual IList<Item> Items { get; set; }

        public Category()
        {
            Items = new List<Item>();
        }

        public virtual void AddItem(Item item)
        {
            item.Category = this;
            Items.Add(item);
        }
    }
}
