using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Customer
{
    class CustomerService
    {
        CustomerRepo repo = new CustomerRepo();

        public void AddCustomer(string name, string contact)
        {
            repo.Add(new CustomerModel(name, contact));
        }

        public List<CustomerModel> ShowCustomers()
        {
            return repo.GetAll();
        }
    }
}
