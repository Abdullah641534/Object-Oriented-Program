using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Result
    {
        string studentID;
        string name;
        string department;
        int semester;
        int subject1, subject2, subject3, subject4, subject5,total,Average;
        public Result(string ID,string name,string Dep,int sem,int sub1,int sub2, int sub3,int sub4,int sub5)
        {
            this.studentID = ID;
            this.name = name;
            this.department = Dep;
            this.semester = sem;
            this.subject1 = sub1;
            this.subject2 = sub2;
            this.subject3 = sub3;
            this.subject4 = sub4;
            this.subject5 = sub5;
        }

        public void output()
        {
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Subject 1: " + subject1);
            Console.WriteLine("Subject 2 " + subject2);
            Console.WriteLine("Subject 3: " + subject3);
            Console.WriteLine("Subject 4: " + subject4);
            Console.WriteLine("Subject 5: " + subject5);
            Console.WriteLine();

        }
        public void Grade()
        {
            total=subject1+subject2 +subject3 +subject4+subject5;
            Console.WriteLine("Total marks: " + total);
            Average=total/5;
            Console.WriteLine("Average: " + Average);
            if (Average >= 50)
            {
                Console.WriteLine("Grade: A");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }

        static void Main(string[] args)
        {
            Result r1 = new Result("GA_31", "Abdullah", "Computer_Science", 2, 50, 60, 70, 80, 90);
            r1.output();
            r1.Grade();
        }
    }
}
