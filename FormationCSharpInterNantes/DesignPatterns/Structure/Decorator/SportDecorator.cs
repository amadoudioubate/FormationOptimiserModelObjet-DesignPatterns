using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Decorator
{
    internal class SportDecorator : VoitureDecorator
    {
        public SportDecorator(IVoiture voiture) : base(voiture)
        {
        }

        public override void Assembler()
        {
            base.Assembler(); // base.Assembler(); (plus propre) base appelle la méthode assembler de la classe parente, on pouvait l'écrire aussi _voiture.Assembler();
            Console.WriteLine("-- avec options sport");
        } 
    }
}
