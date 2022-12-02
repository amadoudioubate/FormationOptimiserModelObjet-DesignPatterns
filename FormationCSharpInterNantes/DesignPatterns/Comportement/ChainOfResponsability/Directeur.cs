using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability.Plainte;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability
{
    internal class Directeur : MembreEquipe
    {
        public Directeur(string nom, MembreEquipe successeur) : base(nom, successeur)
        {
        }

        public override void Handle(Plainte requete)
        {
            Console.WriteLine("Traitement par le directeur");
            requete.Etat = EtatPlainte.Ferme;
        }
    }
}
