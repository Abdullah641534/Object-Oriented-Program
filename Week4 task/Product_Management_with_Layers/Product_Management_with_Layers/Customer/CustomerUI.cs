using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Customer
{
    internal class CustomerUI
    {
        CustomerService cs = new CustomerService();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== CUSTOMER MANAGEMENT =====");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Show Customers");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter Customer Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Contact: ");
                    string contact = Console.ReadLine();
                    cs.AddCustomer(name, contact);
                    Console.WriteLine("Customer Added Successfully!");
                }
                else if (choice == 2)
                {
                    foreach (CustomerModel c in cs.ShowCustomers())
                    {
                        Console.WriteLine("Name: " + c.Name +" | Contact: " + c.Contact);
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
