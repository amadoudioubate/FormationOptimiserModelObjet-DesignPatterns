using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.TellDontAsk.Exemple2
{
    internal class Customer
    {
        public string CustomerAddress { get; set; }

        public int Id { get; set; }

        public List<Percel> Parsels {get; set;}
    }
}
