using System.ComponentModel;
using System.Runtime.CompilerServices;

using ToDoList.Annotations;

namespace ToDoList.Models
{
    public class Note : INotifyPropertyChanged
    {
        public int Id;
        private string text;
        private Item item;

        public string Text
        {
            get { return text; }
            set { text = value; OnPropertyChanged("Text"); }
        }

        public Item Item
        {
            get { return item; }
            set { item = value; OnPropertyChanged("Item"); }
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
