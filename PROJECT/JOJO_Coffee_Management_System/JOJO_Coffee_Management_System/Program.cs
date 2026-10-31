using JOJO_Coffee_Management_System.Admin;
using JOJO_Coffee_Management_System.Bill;
using JOJO_Coffee_Management_System.Menu;
using JOJO_Coffee_Management_System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MenuRepo menuRepo = new MenuRepo();
            MenuService menuService = new MenuService(menuRepo);
            MenuUI menuUI = new MenuUI(menuService);

            
            BillRepo billRepo = new BillRepo();
            BillService billService = new BillService(billRepo);
            BillUI billUI = new BillUI(billService);

            
            UserRepo userRepo = new UserRepo();
            UserService userService = new UserService(userRepo);
            UserUI userUI = new UserUI(userService, menuService, menuUI, billService, billUI);

            
            AdminRepo adminRepo = new AdminRepo();
            AdminService adminService = new AdminService(adminRepo);
            AdminUI adminUI = new AdminUI(adminService, menuService, menuUI, billService);

            int choice = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("<~~~~~~~~~~~~~~~~~   JOJO COFFEE   ~~~~~~~~~~~~~~~~~~~~>");
                Console.WriteLine("________________________________________________________");
                Console.ForegroundColor= ConsoleColor.DarkCyan;
                Console.WriteLine("1. User Login");
                Console.WriteLine("2. Admin Login");
                Console.ForegroundColor=ConsoleColor.DarkRed;
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    userUI.ShowMenu();
                }
                else if (choice == 2)
                {
                    adminUI.ShowMenu();
                }
                else if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("BYE BYE");
                    break;
                }
            }
        }
    }
}
