using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1
{
    internal interface ISujet
    {
        void Attacher(IObservateur observateur);

        void Detacher(IObservateur observateur); // Je ne veux plus observer mon sujet

        void Notifier(ISujet sujet); // Notifie moi même (ISujet => sujet) à l'Observateur
    }
}
