using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICollectionService
    {
        void Add(Collection collection);   
        void Delete(Collection collection);
        void Update(Collection collection);
        List<Collection> GetAll();

        Collection Get(int id);
    }

}
