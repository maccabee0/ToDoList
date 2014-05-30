using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Note
    {
        public virtual int NoteId { get; set; }
        public virtual string Text { get; set; }
        public virtual int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
