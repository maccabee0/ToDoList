using FluentNHibernate.Mapping;

using ToDoList.Models;

namespace ToDoList.Mappings
{
    public class NoteMap : ClassMap<Note>
    {
        public NoteMap()
        {
            Id(x => x.NoteId);
            Map(x => x.Text);
            Map(x => x.ItemId);
            References(x => x.Item).Column("ItemId");
        }
    }
}
