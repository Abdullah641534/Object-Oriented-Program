using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float area;
            float length;
            String str;
            Console.Write("Enter Length: ");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.Write("The Area is: " + area);
            Console.ReadKey();
        }
    }
}
