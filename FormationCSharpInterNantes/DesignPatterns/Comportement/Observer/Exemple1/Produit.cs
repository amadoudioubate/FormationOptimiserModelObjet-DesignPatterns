using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1
{
    internal class Produit : ISujet // Si on fait implémentation explicitement je suis obligé de passé par l'interface, ici le client va manipuler directement de produit
    {
        public int? Id { get; set; }

        public string Description { get; set; }

        // Je veux observer le prix donc comment je vais le modeliser (quand je modifie le prix on notify directement le client du changement avec Nofifier)
        private int _prix;

        public Produit() // va me permettre d'initialiser ma liste
        {
            // Initialisation du liste
            Observateurs = new(); // Si on detruit le produit ma liste est supprimée
        }

        public int Prix
        {
            get { return _prix; }
            set 
            { 
                _prix = value; // Prix modifier donc il faut notifier
                Notifier(this); // Nofifier moi même Produit donc (this)
            }
        }

        public List<IObservateur> Observateurs { get; set; } // Composition (on pouvait initialiser (new()) ici mais pas conseillé c'est au constructeur de le faire)


        public void Attacher(IObservateur observateur)
        {
            if(!Observateurs.Contains(observateur)) // On test si observateur n'est deja dans la liste on ajoute sinon on ajoute pas
               Observateurs.Add(observateur); // On ajoute un nouvel observateur à ma liste observateurs (abonnement)
        }

        public void Detacher(IObservateur observateur)
        {
            Observateurs.Remove(observateur); // On supprime l'observateur à ma liste observateurs (désabonnement)
        }

        public void Notifier(ISujet sujet)
        {
            // Ici on a un comportement qui relie mes deux classes (Client et Produit)
            foreach (var obs in Observateurs) // Je vais parcourir tous mes observateurs et mettre à jour sujet
            {
                // C'est vraiment de l'evenementiel sans evenement
                obs.MettreAJour(sujet);
            }
        }
    }
}
