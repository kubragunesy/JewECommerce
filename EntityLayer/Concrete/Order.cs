using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        public int orderID { get; set; }

        public int customerID { get; set; }

        public int productID { get; set; }

        public DateTime orderDate { get; set; }

        public  DateTime orderDeliveryDate { get; set; }

        public decimal orderTotalPrice { get; set; }

        public byte orderStatu { get; set; } // if returns 0 it mean order is preparing
                                             // if returns 1 it mean order is shipped
                                             // if returns 2 it mean order is delivered  vs.
        public string orderNote { get; set; }

        public bool cartStatu { get; set; } // if returns 0 it mean order is added to Cart
                                            // if returns 1 it mean order deleted from Cart
    }
}
