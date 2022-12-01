using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Proxy
{
    internal class ProxyMessage : IMessage
    {
        // Message original que je veux proxyfier est IMessage (on pense abstraction)
        private IMessage _messageProxifie;

        public ProxyMessage(IMessage messageProxifie)
        {
            _messageProxifie = messageProxifie;
        }

        public string RecupererContenu()
        {
            string contenuOriginal = _messageProxifie.RecupererContenu();
            // faire ici des vérifications ou des transformations
            var contenuTransforme = contenuOriginal.ToUpper();

            return contenuTransforme;
        }
    }
}
