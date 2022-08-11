using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
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
            using var context= new Context();
            context.Add(entity);
            context.SaveChanges();

        }

        public List<TEntity> GetAll()
        {
            using var context = new Context();
            return context.Set<TEntity>().ToList();
 
        }

        public void Remove(TEntity entity)
        {
            using var context = new Context();
            context.Remove(entity);
            context.SaveChanges();

        }

        public void Update(TEntity entity)
        {
            using var context = new Context();
            context.Update(entity);
            context.SaveChanges();

        }
    }
}
