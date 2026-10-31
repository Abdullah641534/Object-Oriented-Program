using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Customer
{
    class CustomerModel
    {
        public string Name;
        public string Contact;

        public CustomerModel(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }
    }
}
