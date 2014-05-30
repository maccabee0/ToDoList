using FluentNHibernate.Mapping;

using ToDoList.Models;

namespace ToDoList.Mappings
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Table("Items");
            Id(item => item.ItemId);
            Map(item => item.Complete);
            Map(item => item.Task);
            Map(item => item.CategoryId);
            References(x => x.Category).Column("CategoryId");
            HasMany(x => x.Notes).Inverse().Cascade.All();
        }
    }
}
