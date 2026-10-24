using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
     class Product
     {
        public string nameofproduct;
        public string category;
        public double price;
        public int quantity;
        public int minstock;

        public void addproduct()
        {
            Console.Write("Enter name of product: ");
            nameofproduct = Console.ReadLine();

            Console.Write("Enter category: ");
            category = Console.ReadLine();

            Console.Write("Enter stock of product: ");
            quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("Enter minimum stock: ");
            minstock = int.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("\nName: " + nameofproduct);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Stock: " + quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Minimum Stock: " + minstock);
        }

       
        public static void highestprice(List<Product> products)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Product highest = products[0];

            foreach (Product p in products)
            {
                if (p.price > highest.price)
                {
                    highest = p;
                }
            }

            Console.WriteLine("\nProduct with Highest Price:");
            highest.output();
        }

       
        public static void salestax(List<Product> products)
        {
            double taxrate = 0.10; 

            foreach (Product p in products)
            {
                double tax = p.price * taxrate;

                Console.WriteLine(p.nameofproduct +" - Sales Tax: " + tax);
            }
        }

        
        public static void orderproducts(List<Product> products)
        {
            foreach (Product p in products)
            {
                if (p.quantity < p.minstock)
                {
                    Console.WriteLine(p.nameofproduct +" needs to be ordered.");
                }
            }
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string choice;

            do
            {
                Console.WriteLine("\n1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Highest Unit Price");
                Console.WriteLine("4. View Sales Tax");
                Console.WriteLine("5. Products to be Ordered");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Product P1 = new Product();
                    P1.addproduct();
                    products.Add(P1);
                }
                else if (choice == "2")
                {
                    foreach (Product p in products)
                    {
                        p.output();
                    }
                }
                else if (choice == "3")
                {
                    highestprice(products);
                }
                else if (choice == "4")
                {
                    salestax(products);
                }
                else if (choice == "5")
                {
                    orderproducts(products);
                }
                else if (choice == "6")
                {
                    Console.WriteLine("BYE BYE");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

            } while (choice != "6");
        }
    }
}
