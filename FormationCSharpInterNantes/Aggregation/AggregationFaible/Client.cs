using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Aggregation.AggregationFaible
{
    internal class Client
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        // Aggrégation faible : l'objet Client peut vivre (exister) sans l'objet Adresse
        // + Association : le fait qu'un objet fasse partie des attributs d'un autre objet
        public Adresse Adresse { get; set; } 
    }
}
