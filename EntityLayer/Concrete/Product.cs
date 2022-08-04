using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int productID { get; set; }

        public string productName { get; set; }

        public string productImageUrl { get; set; }

        public short productUnitInStock { get; set; }

        public int productUnitPrice { get; set; }

        public string productDescription { get; set; }

        public string productColor { get; set; }

        public int categoryID { get; set; }
        public virtual Category category { get; set; }  

        public int discountID { get; set; }
        public virtual Discount discount { get; set; }

        public int collectionID { get; set; }
        public virtual Collection collection { get; set; }

        public ICollection<PreOrder> preOrders { get; set; }
    }
}
