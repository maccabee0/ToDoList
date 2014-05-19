using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList.Models
{
    public class Item : INotifyPropertyChanged
    {
        public int ID;
        private string task;
        private string category;
        private List<Note> notes; 

        public string Task
        {
            get { return task; }
            set { task = value; OnPropertyChanged("Task"); }
        }

        public string Category
        {
            get { return category; }
            set { category = value; OnPropertyChanged("Category"); }
        }

        public List<Note> Notes
        {
            get { return notes; }
            set { notes = value;OnPropertyChanged("Notes"); }
        } 

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
