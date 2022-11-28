using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Genericite
{
    internal class ProduitDao : IDao<Produit>
    {
        // Implementation explicite int IDao<Produit>.Inserer(Produit obj), nous permet de passer pas l'interface 
        // à l'instanciation 
        int IDao<Produit>.Insert(Produit obj)
        {
            throw new NotImplementedException();
        }

        // Implementation explicite List<Produit> IDao<Produit>.RecupererTout() nous permet de passer pas l'interface 
        // à l'instanciation 
        List<Produit> IDao<Produit>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
