using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Abstract
{
    public interface IRepository
    {
        IEnumerable<Item> GetItems();
        IEnumerable<Item> GetItemsByCategory(int catId); 
        Item GetItemById(int id);
        Item SaveItem(Item item);
        void DeleteItem(Item item);

        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int id);
        Category SaveCategory(Category category);

        IEnumerable<Note> GetNotes();
        IEnumerable<Note> GetNotesByItem(int itemId);
        Note GetNoteById(int id);
        Note SaveNote(Note note);
    }
}
