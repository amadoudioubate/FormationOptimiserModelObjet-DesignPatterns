using FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Implementation;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Abstraction
{
    internal class TelecommandeBasique : Telecommande
    {
        public TelecommandeBasique(IAppareil appareil) : base(appareil)
        {
        }

        public override void AllumerOuEteindre()
        {
            if (_appareil.EstAllume())
                _appareil.Eteindre();
            else
                _appareil.Allumer();
        }

        public override void ChangerCanal(int chaine)
        {
          _appareil.ChangerCanal(chaine);
        }

        public override void ChangerVolume(int volume)
        {
            _appareil.ChangerVolume(volume);
        }
    }
}
