using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Aggregation
{
    internal class Moteur
    {
        public string Motorisation { get; init; }

        public Moteur(string motorisation)
        {
            Motorisation = motorisation;
        }
    }
}
