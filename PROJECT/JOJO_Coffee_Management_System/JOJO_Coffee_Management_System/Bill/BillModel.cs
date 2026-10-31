using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Bill
{
    class BillModel
    {
        public int TotalAmount;
        public int TotalSales;

        public float CalculateDiscount()
        {
            return TotalAmount * 0.10f;
        }

        public float GetFinalBill()
        {
            return TotalAmount - CalculateDiscount();
        }
    }
}
