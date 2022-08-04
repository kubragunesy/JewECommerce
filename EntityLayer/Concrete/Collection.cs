using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Collection
    {
        [Key]
        public int collectionID { get; set; }
        public string collectionName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
