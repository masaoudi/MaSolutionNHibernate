using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUDHibernate.MapByCode.Domain
{
    public class Compte
    {
        public virtual string Numero { get; set; }
        public virtual string Proprietaire { get; set; }
        public virtual decimal Solde { get; set; }

        public override string ToString()
        {
            return string.Format("Compte : {0} - {1} - {2}", Numero, Proprietaire, Solde);
        }

    }
  
}
