using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Menu
{
    class MenuModel
    {
        public int Id;
        public string ItemName;
        public int Price;

        public MenuModel(int id, string itemName, int price)
        {
            Id = id;
            ItemName = itemName;
            Price = price;
        }
    }
}
