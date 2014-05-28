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
