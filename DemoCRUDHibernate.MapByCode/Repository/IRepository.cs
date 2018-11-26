using DemoCRUDHibernate.MapByCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUDHibernate.MapByCode.Repository
{
    public interface IRepository
    {
        void Create(object obj);
        void Delete(object obj);
        void Update(object obj);
        object FindById(Type objType, object objId);
        IQueryable<TEntity> FindAll<TEntity>();
    }
}
