using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Polymorphisme
{
    internal class PolyTest
    {
        // 3 polymorphismes (ad-hoc, sous-typage (héritage / implémentation) ,   ) 


        // ad - hoc(ou niveau de fonction avec des GetType), en C# on utilise plus ad-hoc car on a 
        // d'autres polymorphismes bcp plus avancés
        public static void Buy(Object obj) // Table... sont des Object, donc on p le passer tout type d'objet
        {
           
            // Test type, si obj est de type IPliable si oui alors on crée variable pliable
            // On peut utiliser GetType aussi
            if (obj is IPliable pliable)
            {
                pliable.Plier();
            }
        }


        // sous-typage (héritage / implémentation), qui est bcp plus utilisé en c#, ici plus de sécurité on p pas le passer tout type d'objet

        public static void Buy(IPliable pliable)
        {
            // pas besoin de tester le type à chaque fois
            pliable.Plier();
        }

        // types paramétriques (généricité)

        public static void Buy<T>(T pliable) where T : IPliable // paramètre générique sur lequel on ajoute une contrainte générique T est forcement une IPliable
        {
            pliable.Plier();
        }
    }
}
