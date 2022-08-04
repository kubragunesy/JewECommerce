using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string categoryImageUrl { get; set; }

        public ICollection<Product> products { get; set; }
    }
}



