using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Remand:IEntity
    {
        [Key]
        public int remandID { get; set; }
        public DateTime remandDate { get; set; }
        [StringLength(200)]
        public string remandReason { get; set; }
        public bool? RemandStatu { get; set; } // if return 0 it means refunded
                                              // if return 1 it means not refunded yet

        public int preOrderID { get; set; }
        public virtual PreOrder preOrder { get; set; }
    }
}
