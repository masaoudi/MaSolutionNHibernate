using System;
using System.Text;
using System.Collections.Generic;


namespace DemoOnToManyHibernate.Domain {
    
    public class Product {
        public virtual int Id { get; set; }
        public virtual Category Categories { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal? Unitprice { get; set; }
    }
}
