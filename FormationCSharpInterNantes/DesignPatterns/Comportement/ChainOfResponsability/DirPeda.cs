using static FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability.Plainte;
using static System.Console;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability
{
    internal class DirPeda : MembreEquipe
    {
        public DirPeda(string nom, MembreEquipe successeur) : base(nom, successeur)
        {
        }

        public override void Handle(Plainte requete)
        {
            if (requete.Type == 2)
            {
                WriteLine("Traitement par le directeur pédagogique");
                requete.Etat = EtatPlainte.Ferme;
            }
            else if (_successeur != null)
            {
                WriteLine("Le directeur pédagogique a remonté la demande à son supérieur.");
                _successeur.Handle(requete); // Je ne dois pas savoir à l'avance le successeur => ici on envoie la req au successeur
            }
        }
    }
}
