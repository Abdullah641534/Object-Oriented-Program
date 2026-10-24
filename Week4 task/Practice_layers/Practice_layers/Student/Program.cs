using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_layers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice_layers.Student.UI ui = new Practice_layers.Student.UI();
            ui.menu();
            Console.ReadKey();
        }
    }
}
