using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Purchase
{
    class PurchaceModel
    {
        public string ProductName;
        public int Quantity;
        public double TotalAmount;

        public PurchaceModel(string name, int quantity, double total)
        {
            ProductName = name;
            Quantity = quantity;
            TotalAmount = total;
        }
    }
}
