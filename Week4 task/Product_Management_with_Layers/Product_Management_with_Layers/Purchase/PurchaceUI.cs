using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Purchase
{
    internal class PurchaceUI
    {
        PurchaseService ps = new PurchaseService();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== PURCHASE MANAGEMENT =====");
                Console.WriteLine("1. Add Purchase");
                Console.WriteLine("2. Show Purchases");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price Per Item: ");
                    double price = double.Parse(Console.ReadLine());
                    ps.AddPurchase(name, quantity, price);
                    Console.WriteLine("Purchase Added Successfully!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n--- Purchase List ---");

                    foreach (PurchaceModel p in ps.ShowPurchases())
                    {
                        Console.WriteLine("Product: " + p.ProductName +" | Quantity: " + p.Quantity +" | Total: " + p.TotalAmount);
                    }
                }
                else if (choice == 3)
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
