using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Product
{
    class ProductService
    {
        ProductRepo repo = new ProductRepo();
        public void AddProduct(string name, int stock, double price)
        {
            repo.Add(new ProductModel(name, stock, price));
        }
        public List<ProductModel> ShowProducts()
        {
            return repo.GetAll();
        }
        public bool UpdateStock(int index, int stock)
        {
            if (index < 0 || index >= repo.GetAll().Count || stock < 0)
            return false;
            repo.UpdateStock(index, stock);
            return true;
        }
    }

}
