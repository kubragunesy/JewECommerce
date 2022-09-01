using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Adress:IEntity
    {
        [Key]
        public int adressID { get; set; }
        [StringLength(50)]
        public string adressName { get; set; }
        [StringLength(100)]
        public string adressLine { get; set; }
        public bool? adressStatu { get; set; }

        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
    }
}
