using DemoCRUDHibernate.MapByCode.Helper;
using DemoOnToManyHibernate.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnToManyHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var categories = from cat in session.Query<Category>()
                                 select cat;
                foreach (var item in categories)
                {
                    System.Console.WriteLine(item.Name);
                    foreach (var product in item.Products)
                    {
                        System.Console.WriteLine( "    >>    " +product.Title);
                    }
                }

            }
            Console.WriteLine("BayBay");
            Console.ReadKey();
        }
        
    }
}
