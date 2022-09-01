using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDiscountService
    {
        void Add(Discount discount);
        void Update(Discount discount);
        void Delete(Discount discount);
        List<Discount> GetAll();
        Discount Get(int id);
    }
}
