using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
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
    }
}
