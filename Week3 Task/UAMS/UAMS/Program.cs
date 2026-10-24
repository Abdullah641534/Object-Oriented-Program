using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Subject
    {
        public string code;
        public string type;
        public int creditHours;
        public int subjectFees;

        public Subject(string code, string type, int creditHours, int subjectFees)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.subjectFees = subjectFees;
        }
    }
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public int seats;
        public List<Subject> subjects = new List<Subject>();
        public DegreeProgram(string name, float duration, int seats)
        {
            degreeName = name;
            degreeDuration = duration;
            this.seats = seats;
        }
        public int calculateCreditHours()
        {
            int total = 0;

            foreach (Subject s in subjects)
            {
                total += s.creditHours;
            }
            return total;
        }
        public void AddSubject(Subject s)
        {
            if (calculateCreditHours() + s.creditHours <= 20)
            {
                subjects.Add(s);
                Console.WriteLine("Subject Added");
            }
            else
            {
                Console.WriteLine("Maximum 20 credit hours allowed");
            }
        }
        public bool isSubjectExists(Subject s)
        {
            foreach (Subject sub in subjects)
            {
                if (sub.code == s.code)
                    return true;
            }
            return false;
        }
    }
    class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subject> regSubject = new List<Subject>();
        public DegreeProgram regDegree;
        public Student(string name, int age, double fsc,double ecat, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            fscMarks = fsc;
            ecatMarks = ecat;
            this.preferences = preferences;
        }
        public void calculateMerit()
        {
            merit = (fscMarks + ecatMarks) / 2;
        }
        public int getCreditHours()
        {
            int total = 0;
            foreach (Subject s in regSubject)
            {
                total += s.creditHours;
            }
            return total;
        }
        public void regStudentSubject(Subject s)
        {
            if (regDegree != null && regDegree.isSubjectExists(s) && !regSubject.Contains(s) && getCreditHours() + s.creditHours <= 9)
            {
                regSubject.Add(s);
                Console.WriteLine("Subject Registered");
            }
            else
            {
                Console.WriteLine("Subject registration failed");
            }
        }
        public double calculateFee()
        {
            double total = 0;
            foreach (Subject s in regSubject)
            {
                total += s.subjectFees;
            }
            return total;
        }
    }
    class AdmissionDepartment
    {
        public void giveAdmission(List<Student> students)
        {
            students.Sort((a, b) => b.merit.CompareTo(a.merit));

            foreach (Student s in students)
            {
                foreach (DegreeProgram d in s.preferences)
                {
                    int admitted = 0;

                    foreach (Student st in students)
                    {
                        if (st.regDegree == d)
                        admitted++;
                    }

                    if (admitted < d.seats)
                    {
                        s.regDegree = d;
                        Console.WriteLine(s.name + " admitted in "+ d.degreeName);
                        break;
                    }
                }
            }
        }
    }
    class FeeDepartment
    {
        public void generateFee(List<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s.name + " Fee: "+ s.calculateFee());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DegreeProgram bsCs =new DegreeProgram("BSCS", 4, 2);
            Subject s1 = new Subject("CS101", "Theory", 3, 5000);
            Subject s2 = new Subject("CS102", "Lab", 2, 3000);
            bsCs.AddSubject(s1);
            bsCs.AddSubject(s2);
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            preferences.Add(bsCs);
            Student st1 =new Student("Ali", 20, 80, 90, preferences);
            Student st2 =new Student("Ahmed", 19, 75, 85, preferences);
            st1.calculateMerit();
            st2.calculateMerit();
            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);
            AdmissionDepartment admission = new AdmissionDepartment();
            admission.giveAdmission(students);
            st1.regStudentSubject(s1);
            st1.regStudentSubject(s2);
            FeeDepartment fee = new FeeDepartment();
            fee.generateFee(students);
            Console.ReadKey();
        }
    }
}
