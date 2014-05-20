namespace ToDoList.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Text { get; set; }
        public Item Item { get; set; }
    }
}
