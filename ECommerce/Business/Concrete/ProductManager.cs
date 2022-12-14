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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
           _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(int id)
        {
            return _productDal.Get(p=>p.productID == id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
