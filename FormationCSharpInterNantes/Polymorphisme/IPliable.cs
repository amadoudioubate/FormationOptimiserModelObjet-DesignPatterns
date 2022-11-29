using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Polymorphisme
{
    /// <summary>
    /// Pour répresenter les objets abstraits pliables de la vie réelle
    /// par exemple si j'achète une chaise au magasin une chaise , une table sont pliable
    /// </summary>
    internal interface IPliable
    {
        void Plier();

        void Deplier();
    }
}
