using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_in_And_Sign_up
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Abdullah sajjad\\Semester 2\\OOP\\Week1 Tasks.cs\\Sign_in_And_Sign_up.txt";
            string[] name = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                ReadData(path, name, password);
                Console.Clear();
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.Write("Enter name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p, name, password);
                }
                else if (option == 2)
                {
                    Console.Write("Enter new name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter new password: ");
                    string p = Console.ReadLine();
                    SignUp(path, n, p);
                }
            }
            while (option < 3);
            Console.Read();
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exist");
            Console.Write("Enter Option: ");
            option=int.Parse(Console.ReadLine());
            return option;
        }
        static void SignIn(string n,string p, string[] name, string[] password)
        {
            bool flag = false;
            for(int i = 0;i<5;i++)
            {
                if (n == name[i] && p== password[i])
                {
                    Console.Write("SignIn Successfully...");
                    flag = true;
                }
            }
            if(flag==false)
            {
                Console.Write("Invalid User");
            }
            Console.ReadKey();
        }
        static void SignUp(string path,string n,string p)
        {
            StreamWriter file=new StreamWriter(path,true);
            file.WriteLine(n + ',' + p);
            file.Flush();
            file.Close();
            Console.WriteLine("SignUp Successfully..."); 
            Console.ReadKey();
        }
        static string ParseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int i = 0; i<record.Length;i++)
            {
                if (record[i]==',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item=item+record[i];
                }
            }
            return item;
        }
        static void ReadData(string path, string[] name,string[] password)
        {
            int i = 0;
            if(File.Exists(path))
            {
                StreamReader filevariable=new StreamReader(path);
                string Record;
                while((Record=filevariable.ReadLine())!=null)
                {
                    name[i] = ParseData(Record, 1);
                    password[i]=ParseData(Record, 2);
                    i++;
                    if(i>=5)
                    {
                        break;
                    }
                }
                filevariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
    }
}
