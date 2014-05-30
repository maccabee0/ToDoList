using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;

using ToDoList.Annotations;
using ToDoList.Commands;
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
        private DelegateCommand _saveCatgoryCommand;
        private string _newCategory;

        public ItemListViewModel()
        {
            _repository = new ToDoRepository();
            Items = new ObservableCollection<Item>(_repository.GetItems());
            Item = new Item();
            Categories = _repository.GetCategories().ToList();
            Categories.Add(new Category {CategoryId = 0, CategoryString = "All Categories"});
        }

        public Item Item
        {
            get { return _item; }
            set { _item = value; OnPropertyChanged();}
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }

        public ICollectionView FilterItem
        {
            get { var it = Items.Select(i => i.CategoryId == CategoryId);
                return new CollectionView(it);
            }
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

        public string NewCategory { get { return _newCategory; } set { _newCategory = value;OnPropertyChanged(); } }

        public DelegateCommand SaveCategoryCommand
        {
            get
            {
                return _saveCatgoryCommand ?? (_saveCatgoryCommand = new DelegateCommand(param => SaveNewCategory()));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SaveNewCategory()
        {
            var cat = _repository.SaveCategory(new Category{CategoryString = _newCategory});
            Categories.Add(cat);
            NewCategory = string.Empty;
        }
    }
}
