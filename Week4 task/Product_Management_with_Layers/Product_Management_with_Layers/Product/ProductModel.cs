using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Product
{
    class ProductModel
    {
        public string Name;
        public int Stock;
        public double ProductPrice;

        public ProductModel(string name, int stock, double price)
        {
            Name = name;
            Stock = stock;
            ProductPrice = price;
        }
    }
}
