using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity>
        where TEntity : class, new()

    {
        public void Add(TEntity entity)
        {
            
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException(); 
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
