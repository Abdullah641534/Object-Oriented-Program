using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Student_Record
{
    class student
    {
        public string name;
        public int rollnumber;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public double merit;
        public student(string n, int roll, float cgpa, int matric,int fsc,int ecat,string home)
        {
            this.name = n;
            this.rollnumber = roll;
            this.cgpa = cgpa;
            this.matricMarks = matric;
            this.fscMarks = fsc;
            this.ecatMarks = ecat;
            this.homeTown = home;
        }
        public double calculateMerit()
        {
            merit=fscMarks*0.06+ecatMarks*0.04;
            Console.WriteLine("Yor merit is: " + merit);
            return merit;
        }
        public bool isEligibleforScholarship()
        {
            bool found = false;
            if (merit > 80)
            {
                Console.WriteLine("Are you hostilite(Yes or No): ");
                string hostel=Console.ReadLine();
                if(hostel=="Yes")
                {
                    Console.WriteLine("Yor are ELigible for scholarship");
                    Console.WriteLine();
                    found = true;
                }
            }
            if(found==false)
            {
                Console.WriteLine("Yor are not Eligible for scholarship");
                Console.WriteLine();
            }
            return found;
        }
        public void output()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll number: " + rollnumber);
            Console.WriteLine("CGPA Marks: " + cgpa);
            Console.WriteLine("Matric Marks: " + matricMarks);
            Console.WriteLine("Fsc Marks: " + fscMarks);
            Console.WriteLine("Ecat Marks: " + ecatMarks);
            Console.WriteLine("Home Town: " + homeTown);
        }
        static void Main(string[] args)
        {
            student s1 = new student("Abdullah", 31, 3, 740, 1150, 300, "Lahore");
            s1.output();
            s1.calculateMerit();
            s1.isEligibleforScholarship();
            student s2 = new student("Danish", 55, 2.9f, 964, 810, 302, "Chiniot");
            s2.output();
            s2.calculateMerit();
            s2.isEligibleforScholarship() ;
            student s3 = new student("Hassaan", 44, 3.1f, 800, 1140, 350, "Jallo");
            s3.output();
            s3.calculateMerit();
            s3.isEligibleforScholarship();
        }
    }
}
