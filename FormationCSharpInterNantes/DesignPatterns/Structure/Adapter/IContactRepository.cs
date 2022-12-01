using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Adapter
{
    internal interface IContactRepository
    {
        string RecupererContactXml(string cheminFichier);

        List<Contact> DepuisXml(string xml);
    }
}
