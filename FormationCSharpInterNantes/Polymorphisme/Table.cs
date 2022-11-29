using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Polymorphisme
{
    /// <summary>
    /// Table objet concrèt va implementer IPliable objet abstrait (interface)
    /// Quand on implémente une interface les membres sont publics, c'est un contrat, on ne peut pas mettre private
    /// </summary>
    internal class Table : IPliable
    {
        // Implementation implicite
        /*public void Deplier()
        {

        }*/
        // Deplier n'est pas definie dans Table , c'est une implémentation explicite (on n'a pas public)
        // Pour accéder Deplier et Plier on passe par l'interface IPliable
        void IPliable.Deplier()
        {
            Console.WriteLine("Déplier....");
        }

        void IPliable.Plier()
        {
            Console.WriteLine("Plier....");
        }
    }
}
