using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Genericite
{
    internal sealed class Produit : TableBase
    {
        public string Description { get; set; } = String.Empty;

        public double Prix { get; set; }  
        
        // On crée une classe tableBase pour eviter de répetiter Id
    }
}
