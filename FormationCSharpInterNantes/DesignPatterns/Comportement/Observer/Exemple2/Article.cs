using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple2
{
    /// <summary>
    /// Article est l'objet que je veux observer, un atricle va gérer deux évenements différents donc on va mettre deux listes
    /// </summary>
    internal class Article : IObservable<EvenementChangementPrix>
    {
        public string Description { get; set; }

        private List<IObserver<EvenementChangementPrix>> _obervers;

        private double _prix;

        public Article()
        {
            _obervers = new();
        }

        public double Prix
        {
            get { return _prix; }
            set
            {
                _prix = value; // Prix modifier donc il faut notifier
                var e = new EvenementChangementPrix(DateTime.Now, "Changement prix de " + Description + " : " + Prix); // Envoyer mon evenement à mes observateurs
                
                foreach (var obs in _obervers)
                    obs.OnNext(e); // Envoie mon événement
                
            }
        }



        // Comme Attacher dans le normal sans Framework
        // Retourne IDisposable veut dire que mon objet va avoir une méthode IDispose, mais on a pas besoin de IDispose
        public IDisposable Subscribe(IObserver<EvenementChangementPrix> observer)
        {
            if(!_obervers.Contains(observer))
                   _obervers.Add(observer);

            // Je retourne un nouvel article IDisposable
            return new Desabonnement(_obervers, observer);
        }
    }
}
