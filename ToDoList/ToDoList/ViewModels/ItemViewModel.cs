using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class ItemViewModel
    {
        private Item _item;

        private ObservableCollection<Item> _items;

        public ItemViewModel()
        {
            Item = new Item();
            Items = new ObservableCollection<Item>();
        }

        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { _items = value; }

        }

    }
}
