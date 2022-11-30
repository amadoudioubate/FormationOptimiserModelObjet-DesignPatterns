using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.TellDontAsk.Exemple2
{
    internal class ParcelDeliveryService
    {
        public void DeliveryParcel(long customerId)
        {

            // Accès au repository... (Les DAO ici)
            Customer cust = CustomerDao.FindById(customerId); 
            List<Percel> percelList = PercelDao.FindByCustomerId(customerId);
            // Je dis de livrer au client qui a id (customerId)
            var supp = new Supplier();
            supp.Deliver(customerId);
        }
    }
}
