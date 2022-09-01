using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class BankCard:IEntity
    {
        [Key]
        public int bankCardID { get; set; }
        [StringLength(50)]
        public string bankCardName { get; set; }
        [StringLength(50)]
        public string bankCardNo { get; set; }
        [StringLength(50)]
        public string bankCardType { get; set; }
        [StringLength(5)]
        public string bankCardExpiryDate { get; set; }
        public bool? bankCardStatu { get; set; }

        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
    }
}
