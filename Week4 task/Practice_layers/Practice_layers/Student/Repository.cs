using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_layers.Student
{
    public class Repository
    {
        List<Model> students = new List<Model>();
        public void add_student(Model student)
        {
            students.Add(student);
        }
    }
}
