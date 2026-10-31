using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Menu
{
    class MenuRepo
    {
        private string filePath = "menu.txt";
        public void SaveMenu(List<MenuModel> list)
        {
            List<string> lines = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                lines.Add(list[i].ItemName);
                lines.Add(list[i].Price.ToString());
            }

            File.WriteAllLines(filePath, lines);
        }
        public List<MenuModel> LoadMenu()
        {
            List<MenuModel> list = new List<MenuModel>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int generatedId = 1;

                for (int i = 0; i < lines.Length - 1; i += 2)
                {
                    string name = lines[i];
                    int price = int.Parse(lines[i + 1]);

                    MenuModel item = new MenuModel(generatedId, name, price);
                    list.Add(item);
                    generatedId++;
                }
            }
            return list; 
        }
    }
}
