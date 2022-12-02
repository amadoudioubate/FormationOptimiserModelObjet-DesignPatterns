using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple2
{
    /// <summary>
    /// Evenement changement de prix , on peut créer d'autres evenement classe
    /// </summary>
    internal class EvenementChangementPrix
    {
        public DateTime EvenementDate { get; set; }

        public string MessageNotif { get; set; }

        // Pas obligé de le mettre mais je le met cas même
        public EvenementChangementPrix(DateTime evenementDate, string messageNotif)
        {
            EvenementDate = evenementDate;
            MessageNotif = messageNotif;
        }
    }
}
