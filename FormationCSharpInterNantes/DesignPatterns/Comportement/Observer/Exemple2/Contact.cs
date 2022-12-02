using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple2
{
    /// <summary>
    /// Contact est un observateur
    /// </summary>
    internal class Contact : IObserver<EvenementChangementPrix>
    {
        public string Nom { get; set; }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(EvenementChangementPrix value)
        {
            Console.WriteLine(value.EvenementDate.ToString("dd/MM/yy") + " : " + value.MessageNotif);
        }
    }
}
