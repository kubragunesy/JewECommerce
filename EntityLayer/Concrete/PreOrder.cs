using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PreOrder
    {
        [Key]
        public int preOrderID { get; set; }

        
        public DateTime preOrderDate { get; set; }

        public  DateTime preOrderDeliveryDate { get; set; }

        public int preOrderQuantity { get; set; }

        public byte preOrderStatu { get; set; } // if returns 0 it mean order is preparing
                                             // if returns 1 it mean order is shipped
                                             // if returns 2 it mean order is delivered  vs.
        public string preOrderNote { get; set; }

        public bool cartStatu { get; set; } // if returns 0 it mean order is added to Cart
                                            // if returns 1 it mean order deleted from Cart

        public int customerID { get; set; }
        public virtual Customer customer { get; set; }

        public int productID { get; set; }
        public virtual Product product { get; set; }

        public ICollection<Remand>remands { get; set; }

        public int paymentMethodID { get; set; }
        public virtual PaymentMethod paymentMethod { get; set; }

    }
}
