using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using DemoOnToManyHibernate.Domain;


namespace DemoOnToManyHibernate.Maps {
    
    
    public class CategoryMap : ClassMapping<Category> {
        
        public CategoryMap() {
			Schema("dbo");
            Table("Categories");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Name);
			Bag(x => x.Products, colmap =>  { colmap.Key(x => x.Column("IdCategory")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
