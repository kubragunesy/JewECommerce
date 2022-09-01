using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PaymentMethod:IEntity
    {
        [Key]
        public int paymentMethodID { get; set; }
        [StringLength(50)]
        public string paymentMethodName { get; set; }
        public bool? paymentMethodStatu { get; set; }

        public ICollection<PreOrder> preOrders { get; set; }
    }
}
