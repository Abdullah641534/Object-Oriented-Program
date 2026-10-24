using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_layers.Student
{
    public class Service
    {
        public readonly Repository repo=new Repository();
        public void add_student(string n,int roll)
        {
            Model s=new Model(n,roll);
            repo.add_student(s);
        }
    }
}
