using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Product
{
    class ProductRepo
    {
        public List<ProductModel> products = new List<ProductModel>();
        public void Add(ProductModel p)
        {
            products.Add(p);
        }
        public List<ProductModel> GetAll()
        {
            return products;
        }
        public void UpdateStock(int index, int stock)
        {
            products[index].Stock = stock;
        }
    }
}
