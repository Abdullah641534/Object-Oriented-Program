using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numb = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number: ");
                numb[i] = int.Parse(Console.ReadLine());
            }
            int largest = 0;
            for (int i = 0; i < 3; i++)
            {
                if (numb[i] > largest)
                {
                    largest = numb[i];
                }
            }
            Console.WriteLine("Largest number: " + largest);
            Console.ReadKey();
        }
    }
}
