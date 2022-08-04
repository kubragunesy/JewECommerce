using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Adress
    {
        [Key]
        public int adressID { get; set; }
        public string adressName { get; set; }
        public string adressLine { get; set; }


        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
    }
}



