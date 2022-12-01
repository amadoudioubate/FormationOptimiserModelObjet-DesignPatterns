namespace FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Implementation
{
    internal interface IAppareil
    {
        bool EstAllume(); // Sera faux s'il est eteint et false s'il est allumé
        void ChangerVolume(int volume);
        void ChangerCanal(int chaine);

        void Allumer();

        void Eteindre();
    }
}
