using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using ToDoList.Annotations;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class EditItemViewModel : INotifyPropertyChanged
    {
        //private int itemId;
        private string _task;
        private int _categoryId;
        private List<Category> _categories;

        public int ItemId { get; set; }

        public string Task
        {
            get { return _task; }
            set { _task = value; OnPropertyChanged(); }
        }

        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; OnPropertyChanged(); }
        }

        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; OnPropertyChanged(); }
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
