using JOJO_Coffee_Management_System.Bill;
using JOJO_Coffee_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.User
{
    class UserUI
    {
        private UserService _userService;
        private MenuService _menuService;
        private MenuUI _menuUI;
        private BillService _billService;
        private BillUI _billUI;

        public UserUI(UserService userService, MenuService menuService, MenuUI menuUI, BillService billService, BillUI billUI)
        {
            _userService = userService;
            _menuService = menuService;
            _menuUI = menuUI;
            _billService = billService;
            _billUI = billUI;
        }

        public void ShowMenu()
        {
            int choice = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("=== USER PANEL ===");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1. View Menu");
                Console.WriteLine("2. Order Single Item");
                Console.WriteLine("3. Order Multiple Items");
                Console.WriteLine("4. View Total Bill");
                Console.WriteLine("5. Discount Calculation");
                Console.WriteLine("6. Search Item");
                Console.WriteLine("7. Clear Bill");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("8. Logout");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    Console.ForegroundColor= ConsoleColor.DarkBlue;
                    _menuUI.DisplayMenu();
                }
                else if (choice == 2)
                {
                    Console.ForegroundColor=ConsoleColor.DarkMagenta;
                    OrderSingle();
                }
                else if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    OrderMultiple();
                }
                else if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    _billUI.ShowBill();
                }
                else if (choice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    _billUI.ShowDiscount();
                }
                else if (choice == 6)
                {
                    SearchItem();
                }
                else if (choice == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _billService.ClearBill();
                    Console.WriteLine("Bill Cleared!");
                }

                if (choice != 8)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 8);
        }

        private void OrderSingle()
        {
            Console.Write("Enter item number: ");
            int id = int.Parse(Console.ReadLine());

            MenuModel item = _menuService.GetItemById(id);

            if (item != null)
            {
                Console.Write("Enter quantity: ");
                int qty = int.Parse(Console.ReadLine());

                _billService.AddToBill(item.Price, qty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Item added to bill!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid item number!");
            }
        }

        private void OrderMultiple()
        {
            int id = 0;
            do
            {
                Console.Write("Enter item number (0 to exit): ");
                id = int.Parse(Console.ReadLine());

                if (id != 0)
                {
                    MenuModel item = _menuService.GetItemById(id);
                    if (item != null)
                    {
                        Console.Write("Enter quantity: ");
                        int qty = int.Parse(Console.ReadLine());

                        _billService.AddToBill(item.Price, qty);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Added!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid item!");
                    }
                }
            } while (id != 0);
        }

        private void SearchItem()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Enter item name to search: ");
            string name = Console.ReadLine();

            MenuModel item = _menuService.SearchItem(name);

            if (item != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Found: " + item.ItemName + " - Price: " + item.Price);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Item not found!");
            }
        }
    }
}
