using System;
using System.Text;
using System.Collections.Generic;


namespace DemoOnToManyHibernate.Domain {
    
    public class Category {
        public Category() { }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
