using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.Write("Enter number1: ");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Enter number2: ");
            num2=int.Parse(Console.ReadLine());
            int result=add(num1,num2);
            Console.Write("Sum is: " + result);
            Console.Read();
        }
        static int add(int num1,int num2) 
        {
            return num1+num2; 
        }
    }
}
