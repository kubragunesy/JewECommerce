using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Remand
    {
        [Key]
        public int remandID { get; set; }

        public int preOrderID { get; set; }
        public virtual PreOrder preOrder { get; set; }

        public DateTime remandDate { get; set; }

        public string remandReason { get; set; }

        public bool RemandStatu { get; set; } // if return 0 it means refunded
                                              // if return 1 it means not refunded yet

    }
}
