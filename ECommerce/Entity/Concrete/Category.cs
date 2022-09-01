using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public int categoryID { get; set; }
        [StringLength(50)]
        public string categoryName { get; set; }
        public string categoryImageUrl { get; set; }
        public bool? categoryStatu { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
