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
    public class DiscountManager : IDiscountService
    {
        IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
        public void Add(Discount discount)
        {
            _discountDal.Add(discount);
        }

        public void Delete(Discount discount)
        {
           _discountDal.Delete(discount);
        }

        public Discount Get(int id)
        {
            return _discountDal.Get(d => d.discountID == id);
        }

        public List<Discount> GetAll()
        {
            return _discountDal.GetAll();
        }

        public void Update(Discount discount)
        { 
            _discountDal.Update(discount);
        }
    }
}
