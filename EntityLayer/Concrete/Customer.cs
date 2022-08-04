using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string customerFirstName { get; set; }

        public string customerLastName { get; set; }

        public string customerMail { get; set; }

        public string customerPhone { get; set; }

        public DateTime customerBirthDate { get; set; }
        public DateTime customerCreatedDate { get; set; }

        public string customerImageUrl { get; set; }

        public bool customerStatu { get; set; }


        public ICollection<Admin> admins { get; set; } 
        public ICollection<Adress> adresses { get; set; }
        public ICollection<PreOrder> preOrders { get; set; }
        public ICollection<BankCard> bankCards { get; set; }
    }
}
