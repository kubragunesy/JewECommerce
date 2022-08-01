using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CreditCart
    {
        public int CardID { get; set; }

        public int cardName { get; set; }

        public int customerID { get; set; }

        public bool cardType { get; set; }// if returns 1 it will be Visa
                                          // if returns 0 it will be MasterCard 
        public string bankName { get; set; }

        public string cardNo { get; set; }//if we dont make aritmetical calculations with numbers
                                          //no need to keep as a integer

        public DateOnly ExpiryDate { get; set; }

    }
        
}

