using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Genericite
{
    // Pour faire que Id ne soit bloqué seulement à int on peut rendre TableBase générique 
    // Donc on met TableBase<Tcle> après on peut dit mettre public Tcle Id {get; set; }
    // Après partout il y a TableBase on p especifier 
    internal abstract class TableBase<Tcle>
    {
        public Tcle Id { get; set; } 
    }
}
