using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_practice
{
     class Student
     {
        public string name;
        public int matric;
        public int fsc;

        public Student()
        {
            name = null;
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, int matric,int fsc)
        {
            this.name=name;
            this.matric = matric;
            this.fsc = fsc;
        }
        public Student(Student s)
        {
            this.name=s.name;
            this.matric=s.matric;
            this.fsc = s.fsc;
        }

        public void output()
        {
            Console.WriteLine("Name: " +this.name);
            Console.WriteLine("Matric marks: " + this.matric);
            Console.WriteLine("Fsc marks: " + this.fsc);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.output();
            Student s2 = new Student("Abdullah");
            s2.output();
            Student s3 = new Student("Abdullah", 1130, 1140);
            s3.output();
            Student s4 = new Student(s3);
            s4.output();

        }
    }
}
