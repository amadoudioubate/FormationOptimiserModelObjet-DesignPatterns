using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Decorator
{
    internal class LuxeDecorator : VoitureDecorator
    {
        public LuxeDecorator(IVoiture voiture) : base(voiture)
        {
        }

        public override void Assembler()
        {
            base.Assembler();
            Console.WriteLine("-- avec options luxe");

            // ne pas appeler base.Assembler() ici car on doit d'abord manipuler l'objet à emballer avant d'ajouter des décorations
        }
    }
}
