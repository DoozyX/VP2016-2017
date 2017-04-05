using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class ProductItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public ProductItem(Product product, int quantity) {
            Product = product;
            Quantity = quantity;
            Price = quantity * product.Price;
        }
        public override string ToString() {
            return String.Format("{0} {1:0.0} x {2: 0.0} = {3:0.00}", Product.Name, Quantity, Product.Price,
                Quantity * Price);
        }
    }
}
