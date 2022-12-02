namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1
{
    internal interface IObservateur
    {
        // Méthode pour mettre à jour Observateur
        void MettreAJour(ISujet sujet); // Je met en paramètre le sujet qui a été mis à jour
    }
}