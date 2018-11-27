using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using DemoOnToManyHibernate.Domain;


namespace DemoOnToManyHibernate.Maps {
    
    
    public class ProductMap : ClassMapping<Product> {
        
        public ProductMap() {
			Schema("dbo");
            Table("Products");
            Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Title);
			Property(x => x.Unitprice);
			ManyToOne(x => x.Categories, map => { map.Column("IdCategory"); map.Cascade(Cascade.None); });

        }
    }
}
