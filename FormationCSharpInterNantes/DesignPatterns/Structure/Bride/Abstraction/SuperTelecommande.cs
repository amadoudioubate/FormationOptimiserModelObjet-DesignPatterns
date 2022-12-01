using FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Implementation;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Abstraction
{
    internal class SuperTelecommande : TelecommandeBasique
    {
        public SuperTelecommande(IAppareil appareil) : base(appareil)
        {
        }

        public void Sourdine()
        {
            ChangerVolume(0);
        }
    }
}
