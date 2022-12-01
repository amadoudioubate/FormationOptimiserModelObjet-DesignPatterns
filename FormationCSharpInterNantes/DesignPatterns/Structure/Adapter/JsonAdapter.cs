using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Adapter
{
    internal class JsonAdapter : IJsonAdapter
    {
        private IContactRepository _xmlRepo;

        public JsonAdapter(IContactRepository xmlRepo)
        {
            _xmlRepo = xmlRepo;
        }

        string IJsonAdapter.RecupererContactJson(string cheminFichier) // RequestSpecifiRequest dans UML
        {
            string xml = _xmlRepo.RecupererContactXml(cheminFichier);

            //Transformation en JSON
            List<Contact> contacts = _xmlRepo.DepuisXml(cheminFichier); // _xmlRepo.DepuisXml(cheminFichier) fourni par mon Service
            return JsonSerializer.Serialize(contacts); // Conversion objet en json en nous de le faire (contacts xml sera serialisé en json) => .Net 6 version
        }
    }
}
