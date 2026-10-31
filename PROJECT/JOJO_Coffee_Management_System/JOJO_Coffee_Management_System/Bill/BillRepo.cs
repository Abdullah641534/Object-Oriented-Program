using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Bill
{
    class BillRepo
    {
        private string filePath = "bill.txt";
        private string salesfile = "Sales.txt";
        public void SaveBill(BillModel bill)
        {
            File.WriteAllText(filePath, bill.TotalAmount.ToString());
            File.WriteAllText(salesfile, bill.TotalSales.ToString());
        }
        public BillModel LoadBill()
        {
            BillModel bill = new BillModel();
            bill.TotalAmount = 0;
            bill.TotalSales = 0;

            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                int amount = 0;
                if (int.TryParse(text, out amount))
                {
                    bill.TotalAmount = amount;
                }
            }
            if (File.Exists(salesfile))
            {
                string salesText = File.ReadAllText(salesfile);
                int sales = 0;
                if (int.TryParse(salesText, out sales))
                {
                    bill.TotalSales = sales;
                }
            }
            return bill;
        }
    }
}
