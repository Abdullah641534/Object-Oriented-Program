using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Product
{
    class ProductUI
    {
        ProductService ps = new ProductService();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== PRODUCT MANAGEMENT =====");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Update Stock");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());
                    ps.AddProduct(name, stock, price);
                    Console.WriteLine("Product Added Successfully!");
                }
                else if (choice == 2)
                {
                    int index = 0;
                    foreach (ProductModel p in ps.ShowProducts())
                    {
                        Console.WriteLine(index + ". Name: " + p.Name +" | Stock: " + p.Stock +" | Price: " + p.ProductPrice);
                        index++;
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter Product Index: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    if (ps.UpdateStock(index, stock))
                        Console.WriteLine("Stock Updated Successfully!");
                    else
                        Console.WriteLine("Invalid Index or Stock!");
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                }
            }
        }
    }
}
