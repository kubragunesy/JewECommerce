using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Collection:IEntity
    {

        [Key]
        public int collectionID { get; set; }
        [StringLength(50)]
        public string collectionName { get; set; }
        public bool? collectionStatu { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
