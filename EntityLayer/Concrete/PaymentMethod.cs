using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PaymentMethod
    {
        [Key]
        public int paymentMethodID { get; set; }
        public string paymentMethodName { get; set; }
        public ICollection<PreOrder> preOrders { get; set; }


    }
}
