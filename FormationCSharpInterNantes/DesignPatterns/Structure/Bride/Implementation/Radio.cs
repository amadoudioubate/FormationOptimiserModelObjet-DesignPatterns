namespace FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Implementation
{
    internal class Radio : IAppareil // Implementation explicite
    {
        void IAppareil.Allumer()
        {
            throw new NotImplementedException();
        }

        void IAppareil.ChangerCanal(int chaine)
        {
            throw new NotImplementedException();
        }

        void IAppareil.ChangerVolume(int volume)
        {
            throw new NotImplementedException();
        }

        bool IAppareil.EstAllume()
        {
            throw new NotImplementedException();
        }

        void IAppareil.Eteindre()
        {
            throw new NotImplementedException();
        }
    }
}
