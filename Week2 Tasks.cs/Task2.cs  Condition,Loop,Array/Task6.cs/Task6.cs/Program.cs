using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter washing machine price: ");
            double washingMachinePrice = double.Parse(Console.ReadLine());
            Console.Write("Enter toy price: ");
            int toyPrice = int.Parse(Console.ReadLine());

            double money = 0;
            int toys = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    double amount = (birthday / 2) * 10;
                    money += amount - 1;
                }
                else
                {
                    toys++;
                }
            }

            money += toys * toyPrice;

            if (money >= washingMachinePrice)
            {
                Console.WriteLine("Yes! " + (money - washingMachinePrice).ToString("F2"));
            }
            else
            {
                Console.WriteLine("No! " + (washingMachinePrice - money).ToString("F2"));
            }
        }
    }
}
