using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Student_Management_System
{
    class Student
    {
        public int RollNumber;
        public string Name;
        public double GPA;
        public List<Student> Friends;

        public Student(int rollNumber, string name, double gpa)
        {
            RollNumber = rollNumber;
            Name = name;
            GPA = gpa;
            Friends = new List<Student>();
        }

        public void Display()
        {
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("GPA: " + GPA);
        }
    }

    class Department
    {
        public string DepartmentName;
        public List<Student> Students;

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Students = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
                Console.WriteLine("Student enrolled successfully.");
            }
            else
            {
                Console.WriteLine("Student already enrolled.");
            }
        }

        public void DisplayStudents()
        {
            Console.WriteLine("\nDepartment: " + DepartmentName);

            if (Students.Count == 0)
            {
                Console.WriteLine("No students enrolled.");
                return;
            }

            foreach (Student student in Students)
            {
                student.Display();
                Console.WriteLine("------------------");
            }
        }
    }

    class Program
    {
        static List<Student> allStudents = new List<Student>();
        static List<Department> allDepartments = new List<Department>();

        static Student FindStudent(int rollNumber)
        {
            foreach (Student s in allStudents)
            {
                if (s.RollNumber == rollNumber)
                {
                    return s;
                }
            }

            return null;
        }

        static Department FindDepartment(string name)
        {
            foreach (Department d in allDepartments)
            {
                if (d.DepartmentName == name)
                {
                    return d;
                }
            }

            return null;
        }

        static void AddStudent()
        {
            Console.Write("Enter Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            if (FindStudent(roll) != null)
            {
                Console.WriteLine("Roll number already exists.");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter GPA: ");
            double gpa = double.Parse(Console.ReadLine());

            Student student = new Student(roll, name, gpa);
            allStudents.Add(student);

            Console.WriteLine("Student added successfully.");
        }

        static void CreateDepartment()
        {
            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();

            if (FindDepartment(name) != null)
            {
                Console.WriteLine("Department already exists.");
                return;
            }

            Department department = new Department(name);
            allDepartments.Add(department);

            Console.WriteLine("Department created successfully.");
        }

        static void EnrollStudent()
        {
            Console.Write("Enter Student Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Student student = FindStudent(roll);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();

            Department department = FindDepartment(name);

            if (department == null)
            {
                Console.WriteLine("Department not found.");
                return;
            }

            department.EnrollStudent(student);
        }

        static void AddFriend()
        {
            Console.Write("Enter Student Roll Number: ");
            int roll1 = int.Parse(Console.ReadLine());

            Student student = FindStudent(roll1);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter Friend's Roll Number: ");
            int roll2 = int.Parse(Console.ReadLine());

            Student friend = FindStudent(roll2);

            if (friend == null)
            {
                Console.WriteLine("Friend not found.");
                return;
            }

            if (student.RollNumber == friend.RollNumber)
            {
                Console.WriteLine("A student cannot be their own friend.");
                return;
            }

            if (student.Friends.Contains(friend))
            {
                Console.WriteLine("Friend already exists.");
                return;
            }

            student.Friends.Add(friend);

            Console.WriteLine("Friend added successfully.");
        }

        static void DisplayAllStudents()
        {
            if (allStudents.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            foreach (Student student in allStudents)
            {
                student.Display();
                Console.WriteLine("------------------");
            }
        }

        static void DisplayDepartmentStudents()
        {
            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();

            Department department = FindDepartment(name);

            if (department == null)
            {
                Console.WriteLine("Department not found.");
                return;
            }

            department.DisplayStudents();
        }

        static void DisplayFriends()
        {
            Console.Write("Enter Student Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Student student = FindStudent(roll);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine("Friends of " + student.Name + ":");

            if (student.Friends.Count == 0)
            {
                Console.WriteLine("No friends found.");
                return;
            }

            foreach (Student friend in student.Friends)
            {
                friend.Display();
                Console.WriteLine("------------------");
            }
        }

        static void CreateStudentFromExisting()
        {
            Console.Write("Enter Existing Student Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Student oldStudent = FindStudent(roll);

            if (oldStudent == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter New Roll Number: ");
            int newRoll = int.Parse(Console.ReadLine());

            if (FindStudent(newRoll) != null)
            {
                Console.WriteLine("Roll number already exists.");
                return;
            }

            Console.Write("Enter New Student Name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter New Student GPA: ");
            double newGpa = double.Parse(Console.ReadLine());

            Student newStudent = new Student(newRoll, newName, newGpa);

            newStudent.Friends = new List<Student>(oldStudent.Friends);

            allStudents.Add(newStudent);

            Console.WriteLine("New student created successfully.");
        }

        static void Main()
        {
            int choice = 0;

            while (choice != 9)
            {
                Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add a New Student");
                Console.WriteLine("2. Create a Department");
                Console.WriteLine("3. Enroll Student in Department");
                Console.WriteLine("4. Add Friend to Student");
                Console.WriteLine("5. Display All Students");
                Console.WriteLine("6. Display Students of a Department");
                Console.WriteLine("7. Display Friends of a Student");
                Console.WriteLine("8. Create Student Using Existing Details");
                Console.WriteLine("9. Exit");

                Console.Write("Enter your choice: ");
                choice =int.Parse(Console.ReadLine());
                
                if(choice == 1)
                {
                    AddStudent();
                }
                else if(choice == 2)
                {
                    CreateDepartment();
                }
                else if(choice == 3)
                {
                    EnrollStudent();
                }
                else if(choice == 4)
                {
                    AddFriend();
                }
                else if(choice == 5)
                {
                    DisplayAllStudents();
                }
                else if(choice == 6)
                {
                    DisplayDepartmentStudents();
                }
                else if(choice == 7)
                {
                    DisplayFriends();
                }
                else if(choice == 8)
                {
                    CreateStudentFromExisting();
                }
                else if(choice == 9)
                {
                    Console.WriteLine("BYE BYE");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }

}
