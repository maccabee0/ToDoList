using FluentNHibernate.Mapping;

using ToDoList.Models;

namespace ToDoList.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Categories");
            Id(x => x.CategoryId);
            Map(x => x.CategoryString);
            HasMany(x => x.Items)
                .Inverse()
                .Cascade.All();
        }
    }
}
