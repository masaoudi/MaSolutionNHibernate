using DemoCRUDHibernate.MapByCode.Domain;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUDHibernate.MapByCode.Mappings
{
    public class CompteMap : ClassMapping<Compte>
    {
        public CompteMap()
        {
            Table("Comptes");
            Id(x => x.Numero, map => map.Generator(Generators.Assigned));
            Property(x => x.Proprietaire);
            Property(x => x.Solde);
        }
    }
}
