namespace FormationCSharpInterNantes.Aggregation
{
    internal class Voiture
    {
        // Une aggrégation forte car je ne peux pas créer de voiture sans moteur: 
        // objet voiture ne peut exister sans moteur (couplage fort)
        
        public Moteur Moteur { get;}

        // Moteur peut exister sans voiture, quand on detruit la voiture, avec ce constructeur (aggrégation)
        public Voiture(Moteur moteur)
        {
            Moteur = moteur;
        }

        // Composition ici avec ce constructeur, il y a une variable qui utilise moteur
        // C# le développeur n'a pas besoin de supprimer dans la plus part des cas de supprimer les objets en memoire, c# le fait
        public Voiture(string motorisation)
        {
            Moteur = new Moteur(motorisation);
        }

        // On passe le parking en paramètre de la méthode Garer, je me sers de parking juste pour me garer après je me sers plus
        // ma voiture ne depend pas forcement de parking , ça pouvait être dependency ou association mais ici c'est association
        // Parking on ne peut pas le mettre dans voiture directement car on n'a besoin de Parking juste pour un temps
        // Association

        public void Garer(Parking parc)
        {
            parc.Garer();
        }

    }
}
