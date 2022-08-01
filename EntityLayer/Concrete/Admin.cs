using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        public int adminID { get; set; }
        public int customerID { get; set; }
        public bool adminStatu { get; set; }
    }
}