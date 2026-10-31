using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_with_Layers.Purchase
{
    class PurchaseRepo
    {
        public List<PurchaceModel> purchases = new List<PurchaceModel>();

        public void Add(PurchaceModel p)
        {
            purchases.Add(p);
        }

        public List<PurchaceModel> GetAll()
        {
            return purchases;
        }
    }
}
