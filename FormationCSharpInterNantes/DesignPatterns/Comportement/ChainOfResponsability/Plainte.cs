using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability
{
    internal class Plainte
    {
        public int NumApprenant { get; set; }

        public int Type { get; set; } // Selon le type, la plainte sera traitée par : 1 - le formateur; 2 - directeur

        public string Message { get; set; }

        public EtatPlainte Etat { get; set; }   

        // Etat de la plainte (Ouvert ou Fermé) donc enum, qui est lié à la classe plainte donc on peut l'imbriquer dans la classe plainte
        // enum dans une classe ok mais struct, eviter de le faire dans une classe
        public enum EtatPlainte
        {
            Ouvert,
            Ferme
        }

        public Plainte(int numApprenant, int type, string message, EtatPlainte etat)
        {
            NumApprenant = numApprenant;
            Type = type;
            Message = message;
            Etat = etat;
        }
    }
}
