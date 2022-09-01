using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int customerID { get; set; }
        [StringLength(100)]
        public string username { get; set; }
        [StringLength(100)]
        public string password { get; set; }
        [StringLength(100)]
        public string customerFirstName { get; set; }
        [StringLength(100)]
        public string customerLastName { get; set; }
        [StringLength(200)]
        public string customerMail { get; set; }
        [StringLength(20)]
        public string customerPhone { get; set; }
        public DateTime? customerBirthDate { get; set; }
        public DateTime? customerCreatedDate { get; set; }
        public string customerImageUrl { get; set; }
        public bool? customerStatu { get; set; }

        public ICollection<Admin> admins { get; set; }
        public ICollection<Adress> adresses { get; set; }
        public ICollection<BankCard> bankCards { get; set; }
        public ICollection<PreOrder> preOrders { get; set; }
    }
}
