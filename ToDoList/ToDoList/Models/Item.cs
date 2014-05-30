using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Item
    {
        public virtual int ItemId { get; set; }
        public virtual string Task { get; set; }
        public virtual bool Complete { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual IList<Note> Notes { get; set; }
        public virtual Category Category { get; set; }

        public Item()
        {
            Notes = new List<Note>();
        }

        public virtual void AddNote(Note note)
        {
            note.Item = this;
            Notes.Add(note);
        }
    }
}
