using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product:IEntity
    {

        [Key]
        public int productID { get; set; }
        [StringLength(100)]
        public string productName { get; set; }

        public string productImageUrl { get; set; }
        public short? productUnitInStock { get; set; }
        public decimal? productUnitPrice { get; set; }
        [StringLength(200)]
        public string productDescription { get; set; }
        [StringLength(100)]
        public string productColor { get; set; }
        public bool? productStatu { get; set; }

        public ICollection<PreOrder> preOrders { get; set; }
        public int categoryID { get; set; }
        public virtual Category category { get; set; }
        public int discountID { get; set; }
        public virtual Discount discount { get; set; }
        public int collectionID { get; set; }
        public virtual Collection collection { get; set; }
    }
}
