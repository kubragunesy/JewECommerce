using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Discount:IEntity
    {
        [Key]
        public int discountID { get; set; }
        [StringLength(50)]
        public string discountName { get; set; }
        public DateTime? discountCreatedDate { get; set; }
        public float? discountRate { get; set; }
        public bool? discountStatu { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
