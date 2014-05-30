using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using ToDoList.Annotations;
using ToDoList.Models;
using ToDoList.Repository;

namespace ToDoList.ViewModels
{
    public class ItemListViewModel : INotifyPropertyChanged
    {
        private Item _item;
        private ObservableCollection<Item> _items;
        private int _categoryId;
        private List<Category> _categories;
        private ToDoRepository _repository;

        public ItemListViewModel()
        {
            _repository = new ToDoRepository();
            Items = new ObservableCollection<Item>(_repository.GetItems());
            Item = new Item();
            Categories = _repository.GetCategories().ToList();
        }

        public Item Item
        {
            get { return _item; }
            set { _item = value; OnPropertyChanged();}
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged();}
        }

        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value;OnPropertyChanged(); }
        }

        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value;OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
