using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity>
    {
        // generic repository
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update (TEntity entity);
        List<TEntity> GetAll();
        TEntity Get(int id);
    }
}
