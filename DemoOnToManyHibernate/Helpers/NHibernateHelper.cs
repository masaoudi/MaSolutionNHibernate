
using DemoOnToManyHibernate.Maps;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Environment = NHibernate.Cfg.Environment;

namespace DemoCRUDHibernate.MapByCode.Helper
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration()
                          .SetProperty(Environment.ConnectionString, @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ProductsDb;Integrated Security=True")
                          .SetProperty(Environment.ConnectionDriver, typeof(SqlClientDriver).AssemblyQualifiedName)
                          .SetProperty(Environment.Dialect, typeof(MsSql2012Dialect).AssemblyQualifiedName)
                          .SetProperty(Environment.ShowSql, "true")
                          .SetProperty(Environment.Hbm2ddlAuto, "update");
                         // .SetProperty(Environment.FormatSql, "true");
                    var modelMapper = new ModelMapper();
                    modelMapper.AddMapping<CategoryMap>();
                    modelMapper.AddMapping<ProductMap>();
                    configuration.AddMapping(modelMapper.CompileMappingForAllExplicitlyAddedEntities());
                    _sessionFactory = configuration.BuildSessionFactory();

                }
                return _sessionFactory;
            }
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}
