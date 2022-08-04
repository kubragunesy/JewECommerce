using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BankCard
    {
        [Key]
        public int bankCardID { get; set; }
        public string bankCardName { get; set; }
        public string bankCardNo { get; set; }
        public bool bankCardType { get; set; }
        public string bankCardExpiryDate { get; set; }
        public int customerID { get; set; }
        public virtual Customer customer { get; set; }

    }
}
