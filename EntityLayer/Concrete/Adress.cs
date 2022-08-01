using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Adress
    {
        public int adressID { get; set; }
        public string adressName { get; set; }
        public string adressLine { get; set; }
        public int customerID { get; set; }
    }
}



