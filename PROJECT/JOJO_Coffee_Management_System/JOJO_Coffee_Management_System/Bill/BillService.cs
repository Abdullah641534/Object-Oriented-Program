using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Bill
{
    class BillService
    {
        private BillRepo _repo;
        public BillModel CurrentBill;

        public BillService(BillRepo repo)
        {
            _repo = repo;
            CurrentBill = _repo.LoadBill();
        }

        public void AddToBill(int price, int quantity)
        {
            CurrentBill.TotalAmount = CurrentBill.TotalAmount + (price * quantity);
            _repo.SaveBill(CurrentBill);
        }

        public void ClearBill()
        {
            CurrentBill.TotalSales += CurrentBill.TotalAmount;
            CurrentBill.TotalAmount = 0;
            _repo.SaveBill(CurrentBill);
        }
    }
}
