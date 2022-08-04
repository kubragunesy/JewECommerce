using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Discount
    {
        [Key]
        public int discountID { get; set; }

        public string discountName { get; set; }

        public DateTime discountCreatedDate { get; set; }

        public float discountRate { get; set; }

        public bool discountStatu { get; set; } 

        public ICollection<Product> products { get; set; }
        

    }
}
