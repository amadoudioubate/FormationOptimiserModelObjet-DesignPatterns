using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Decorator
{
    internal abstract class VoitureDecorator : IVoiture
    {
        private IVoiture _voiture; // Les classes filles n'ont pas besoin d'accéder dont on met private au lieu de protected

        protected VoitureDecorator(IVoiture voiture)
        {
            _voiture = voiture;
        }

        public virtual void Assembler() // Virtual pour pouvoir le redefinir
        {
            _voiture.Assembler();
        }
    }
}
