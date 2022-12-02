using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple2
{
    /// <summary>
    /// En anglais UnSuscribe
    /// Dans Desabonnement, Je vais avoir une liste d'observateur et un objet observateur
    /// </summary>
    internal class Desabonnement : IDisposable
    {
        private List<IObserver<EvenementChangementPrix>> _observers;
        private IObserver<EvenementChangementPrix> _observer;

        public Desabonnement(List<IObserver<EvenementChangementPrix>> observers, IObserver<EvenementChangementPrix> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if(_observer != null)
                _observers.Remove(_observer);
        }
    }
}
