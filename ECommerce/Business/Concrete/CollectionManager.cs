using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CollectionManager : ICollectionService
    {
        ICollectionDal _collectionDal;

        public CollectionManager(ICollectionDal collectionDal)
        {
            _collectionDal = collectionDal;
        }

        public void Add(Collection collection)
        {
             _collectionDal.Add(collection);    
        }

        public void Delete(Collection collection)
        {
            _collectionDal.Delete(collection);
        }

        public Collection Get(int id)
        {
            return _collectionDal.Get(c => c.collectionID == id);
        }

        public List<Collection> GetAll()
        {
            return _collectionDal.GetAll();
        }

        public void Update(Collection collection)
        {
            _collectionDal.Update(collection);
        }
    }
}
