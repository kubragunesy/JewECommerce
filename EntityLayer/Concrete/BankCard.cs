using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BankCard
    {
        public int bankCardID { get; set; }
        public string bankCardName { get; set; }
        public string bankCardNo { get; set; }
        public bool bankCardType { get; set; }
        public DateOnly bankCardExpiryDate { get; set; }
        public int customerID { get; set; }
    }
}
