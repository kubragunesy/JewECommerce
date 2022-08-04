using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int adminID { get; set; }


        public bool adminStatu { get; set; }

        public int customerID { get; set; }
        public virtual Customer customer { get; set; }

    }
}