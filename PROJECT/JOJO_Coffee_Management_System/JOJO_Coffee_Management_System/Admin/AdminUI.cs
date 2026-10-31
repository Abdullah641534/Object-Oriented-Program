using JOJO_Coffee_Management_System.Bill;
using JOJO_Coffee_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Admin
{
    class AdminUI
    {
        private AdminService _adminService;
        private MenuService _menuService;
        private MenuUI _menuUI;
        private BillService _billService;

        public AdminUI(AdminService adminService, MenuService menuService, MenuUI menuUI, BillService billService)
        {
            _adminService = adminService;
            _menuService = menuService;
            _menuUI = menuUI;
            _billService = billService;
        }

        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            int pass = int.Parse(Console.ReadLine());

            Console.Clear();

            if (_adminService.CheckLogin(user, pass) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Login!");
                Console.ReadKey();
                return;
            }

            int choice = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("=== ADMIN PANEL ===");
                Console.ForegroundColor= ConsoleColor.DarkCyan;
                Console.WriteLine("1. View Menu");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Update Price");
                Console.WriteLine("4. Delete Item");
                Console.WriteLine("5. Total Sales");
                Console.WriteLine("6. Reset Menu");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("7. Logout");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    _menuUI.DisplayMenu();
                }
                else if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Enter item name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter price: ");
                    int price = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _menuService.AddItem(name, price);
                    Console.WriteLine("Item Added Successfully!");
                }
                else if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Enter item ID to update: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter new price: ");
                    int price = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _menuService.UpdatePrice(id, price);
                    Console.WriteLine("Price Updated!");
                }
                else if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Enter item ID to delete: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _menuService.DeleteItem(id);
                    Console.WriteLine("Item Deleted!");
                }
                else if (choice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Total Sales: " + _billService.CurrentBill.TotalSales);
                }
                else if (choice == 6)
                {
                    _menuService.ResetMenu();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Menu Reset Done (All items cleared)!");
                }

                if (choice != 7)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 7);
        }
    }
}
