using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

using ToDoList.Models;

namespace ToDoList.Mappings
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Id(item => item.ItemId);
            Map(item => item.Complete);
            Map(item => item.Task);
            Map(item => item.CategoryId);
            References(x => x.Category).Column("CategoryId");
            HasMany(x => x.Notes).Inverse().Cascade.All();
        }
    }
}
