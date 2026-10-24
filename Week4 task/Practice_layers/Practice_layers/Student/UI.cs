using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice_layers.Student
{
    public class UI
    {
        Service service= new Service();
        public void menu()
        {
            Console.WriteLine("Add student");
            string name="Abdullah";
            Console.WriteLine("Name:" + name);
            int roll=31;
            Console.WriteLine("Roll number: " + roll);
            service.add_student(name, roll);
        }
    }
}
