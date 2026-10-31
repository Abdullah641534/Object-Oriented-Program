using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Customer
{
    class CustomerRepo
    {
        public List<CustomerModel> customers = new List<CustomerModel>();

        public void Add(CustomerModel c)
        {
            customers.Add(c);
        }

        public List<CustomerModel> GetAll()
        {
            return customers;
        }
    }
}
