using DemoCRUDHibernate.MapByCode.Domain;
using DemoCRUDHibernate.MapByCode.Repository;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUDHibernate.MapByCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestFindAll();
            // TestFindById("C1000");
            TestCreate(new Compte {Numero="Z1000", Proprietaire="NOUVEAU", Solde=2000M });
            // TestUpdate(new Compte { Numero = "B1000", Proprietaire = "***** NOUVEAU", Solde = 2000M });
            TestFindAll();
        }

        private static void TestFindAll()
        {
            using (var repository = new RepositoryBase())
            {
                try
                {
                    IQueryable<Compte> all = repository.FindAll<Compte>();
                    foreach (var item in all)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LOG : Attention il y a eu l'expection : " + ex.Message);
                }
            }
        }

        private static void TestFindById(string id)
        {
            using (var repository = new RepositoryBase())
            {
                try
                {
                    Compte c = (Compte)repository.FindById(typeof(Compte), id);
                    Console.WriteLine(c);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LOG : Attention il y a eu l'expection : " + ex.Message);
                }
            }
        }
       

        private static void TestCreate(Compte compte)
        {
            using (var repository = new RepositoryBase())
            {
                try
                {
                  repository.Create(compte);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LOG : Attention il y a eu l'expection : " + ex.Message);
                }
            }

        }
        private static void TestUpdate(Compte compte)
        {

        }


    }
}
