using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.TellDontAsk.Exemple2
{
    internal class Supplier // Livreur, son compartement c'est de livrer donc on ajoute une méthode livrée qui va livrer un client particulier (propriété)
    {
        List<Customer> Customers { get; set; } // un livreur à une liste de client
        public void Deliver(long custemerId)
        {
            // Je récupère un client que j'ai dans ma liste
            var cust = Customers.Find(c => c.Id == custemerId);

            // Itère sur chaque colis que le client à commander
            foreach (var parsel in cust.Parsels)
            {
                Console.WriteLine("Delivering percel to " + cust.CustomerAddress);
                // traitement ralatif à la livraison
            }
        }
    }
}
