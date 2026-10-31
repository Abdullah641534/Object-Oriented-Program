using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Purchase
{
    class PurchaseService
    {
        PurchaseRepo repo = new PurchaseRepo();

        public void AddPurchase(string name, int quantity, double price)
        {
            double total = quantity * price;
            repo.Add(new PurchaceModel(name, quantity, total));
        }
        public List<PurchaceModel> ShowPurchases()
        {
            return repo.GetAll();
        }
    }
}
