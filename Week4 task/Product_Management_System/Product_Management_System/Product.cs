using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_System
{
    class Product
    {
        public string Name;
        public int Stock;
        public double ProductPrice;

        public Product(string name, int stock, double price)
        {
            Name = name;
            Stock = stock;
            ProductPrice = price;
        }
    }

    class Customer
    {
        public string Name;
        public string Contact;

        public Customer(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }
    }

    class Program
    {
        static List<Product> products = new List<Product>();
        static List<Customer> customers = new List<Customer>();

        static void Main()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("\n===== MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Product Management System");
                Console.WriteLine("2. Customer Management System");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ProductMenu();
                        break;

                    case 2:
                        CustomerMenu();
                        break;

                    case 0:
                        Console.WriteLine("Program ended.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void ProductMenu()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("\n===== PRODUCT MANAGEMENT =====");
                Console.WriteLine("1. Add New Product");
                Console.WriteLine("2. Show All Products");
                Console.WriteLine("3. Update Product Stock");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;

                    case 2:
                        ShowProducts();
                        break;

                    case 3:
                        UpdateStock();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter stock quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int stock) || stock < 0)
            {
                Console.WriteLine("Invalid stock!");
                return;
            }

            Console.Write("Enter product price: ");
            if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
            {
                Console.WriteLine("Invalid price!");
                return;
            }

            products.Add(new Product(name, stock, price));

            Console.WriteLine("Product added successfully!");
        }

        static void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\n--- ALL PRODUCTS ---");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(
                    "Product " + (i + 1) +
                    " | Name: " + products[i].Name +
                    " | Stock: " + products[i].Stock +
                    " | Price: " + products[i].ProductPrice
                );
            }
        }

        static void UpdateStock()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available to update.");
                return;
            }

            ShowProducts();

            Console.Write("Enter product number to update: ");
            if (!int.TryParse(Console.ReadLine(), out int number) ||
                number < 1 || number > products.Count)
            {
                Console.WriteLine("Invalid product number!");
                return;
            }

            Console.Write("Enter new stock quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int stock) || stock < 0)
            {
                Console.WriteLine("Invalid stock!");
                return;
            }

            products[number - 1].Stock = stock;

            Console.WriteLine("Product stock updated successfully!");
        }

        static void CustomerMenu()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("\n===== CUSTOMER MANAGEMENT =====");
                Console.WriteLine("1. Add New Customer");
                Console.WriteLine("2. Show All Customers");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;

                    case 2:
                        ShowCustomers();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter customer contact: ");
            string contact = Console.ReadLine() ?? "";

            customers.Add(new Customer(name, contact));

            Console.WriteLine("Customer added successfully!");
        }

        static void ShowCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }

            Console.WriteLine("\n--- ALL CUSTOMERS ---");

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(
                    "Customer " + (i + 1) +
                    " | Name: " + customers[i].Name +
                    " | Contact: " + customers[i].Contact
                );
            }
        }
    }
}
