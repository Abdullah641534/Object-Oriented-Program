using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Menu
{
    class MenuUI
    {
        private MenuService _service;

        public MenuUI(MenuService service)
        {
            _service = service;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("--- COFFEE MENU ---");
            var items = _service.GetAllItems();

            if (items.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Menu is empty!");
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Id + ". " + items[i].ItemName + " - " + items[i].Price);
            }
        }
    }
}
