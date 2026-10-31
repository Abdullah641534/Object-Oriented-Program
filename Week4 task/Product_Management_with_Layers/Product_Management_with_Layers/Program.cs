using Product_Management_with_Layers.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product_Management_with_Layers.Customer;
using Product_Management_with_Layers.Product;
using Product_Management_with_Layers.Purchase;

namespace Product_Management_with_Layers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductUI productUI = new ProductUI();
            CustomerUI customerUI = new CustomerUI();
            PurchaceUI purchaseUI = new PurchaceUI();

            while (true)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("      MANAGEMENT SYSTEM");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Product Management");
                Console.WriteLine("2. Customer Management");
                Console.WriteLine("3. Purchase Management");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    productUI.ShowMenu();
                }
                else if (choice == 2)
                {
                    customerUI.ShowMenu();
                }
                else if (choice == 3)
                {
                    purchaseUI.ShowMenu();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Program Closed!");
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
