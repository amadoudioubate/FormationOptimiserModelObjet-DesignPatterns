
using FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Implementation;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Abstraction
{
    internal abstract class Telecommande // abstract sert à controler l'implementation (la télécommande envoie le signal à l'appareil => il délègue le travail à l'appareil)
    {
        // La classe abstract Telecommande encapsule IAppareil, on met protected car ds l'implémentation des méthodes abstraites on va avoir besoin d'utiliser IAppareil
        protected IAppareil _appareil;

        // Constructeur (constructeur public dans une classe abstraite ne sert à rien car une classe abstraite n'est pas instanciable
        protected Telecommande(IAppareil appareil)
        {
            DefinirAppaeil(appareil);
        }


        // Cette méthode me permettra de changer d'appareil en cours de route avec le constructeur on ne peut pas changer
        // doit rester public, car, on n'a besoin de changer l'appareil en dehors 
        public void DefinirAppaeil(IAppareil appareil)
        {
            _appareil = appareil;
        }


        public abstract void ChangerVolume(int volume);
        public abstract void ChangerCanal(int chaine);

        public abstract void AllumerOuEteindre();
    }
}
