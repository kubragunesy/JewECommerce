using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int productID { get; set; }

        public string productName { get; set; }

        public string productImageUrl { get; set; }

        public short productUnitInStock { get; set; }

        public decimal productUnitPrice { get; set; }

        public string productDescription { get; set; }

        public string productColor { get; set; }

        public int categoryID { get; set; }

        public int discountID { get; set; }

        public int collectionID { get; set; }


    }
}
