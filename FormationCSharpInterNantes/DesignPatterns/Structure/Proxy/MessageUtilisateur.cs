using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Proxy
{
    internal class MessageUtilisateur : IMessage
    {
        private string _contenu;

        public MessageUtilisateur(string contenu)
        {
            _contenu = contenu;
        }

        public string RecupererContenu() => _contenu;
        
    }
}
