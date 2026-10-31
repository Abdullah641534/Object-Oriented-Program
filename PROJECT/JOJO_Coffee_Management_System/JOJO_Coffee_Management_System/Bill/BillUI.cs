using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Bill
{
    class BillUI
    {
        private BillService _service;

        public BillUI(BillService service)
        {
            _service = service;
        }

        public void ShowBill()
        {
            Console.WriteLine("Total Bill: " + _service.CurrentBill.TotalAmount);
        }

        public void ShowDiscount()
        {
            float discount = _service.CurrentBill.CalculateDiscount();
            float final = _service.CurrentBill.GetFinalBill();

            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Bill: " + final);
        }
        public void ShowTotalSales()
        {
            Console.WriteLine("Overall Total Sales: " + _service.CurrentBill.TotalSales);
        }
    }
}
