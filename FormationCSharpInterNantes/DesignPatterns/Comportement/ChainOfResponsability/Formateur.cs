
using static System.Console;
using static FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability.Plainte; // Tous les membres static , plus besoin de mettre le nom de la classe

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability
{
    internal class Formateur : MembreEquipe
    {
        public Formateur(string nom, MembreEquipe successeur) : base(nom, successeur)
        {
        }

        public override void Handle(Plainte requete)
        {
            if( requete.Type == 1)
            {
                WriteLine("Traitement par le formateur");
                requete.Etat = EtatPlainte.Ferme;
            }
            else if( _successeur != null)
            {
                WriteLine("Le formateur a remonté la demande à son supérieur.");
                _successeur.Handle(requete); // Je ne dois pas savoir à l'avance le successeur => ici on envoie la req au successeur
            }
        }


    }
}
