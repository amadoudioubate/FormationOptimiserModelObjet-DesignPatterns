using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FormationCSharpInterNantes.DesignPatterns.Structure.Adapter
{
    internal class ContactRepository : IContactRepository // Implemente explicitement
    {
        List<Contact> IContactRepository.DepuisXml(string xml)
        {
            // Transcrire le document xml en objet c#
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml); // LoadXml => charge document xml

            XmlNodeList noeuds = doc.DocumentElement.SelectNodes("Contacts/Contact"); // XmlNodeList donne la liste de noeuds. 
                                                                                      // SelectNodes selectionne des noeuds à partir de chemin ("Contacts/Contact") => Contacts noeud parent et Contact enfant
            List<Contact> contacts = new List<Contact>(); // Création de liste de contacts
            foreach(XmlNode noeud in noeuds) // Pour chaque noeud dans ma liste de contact je crée mon contact
            {
                var c = new Contact
                {
                    Id = Convert.ToInt32(noeud.Attributes["id"].Value),
                    Nom = noeud.ChildNodes[0].InnerText
                };
                contacts.Add(c);
            }
           
            return contacts;

        }

        string IContactRepository.RecupererContactXml(string cheminFichier)
        {
            // .close() appel .dispose()
            using var stream = new StreamReader(cheminFichier);
            var res = stream.ReadToEnd(); // Lire tout le caractère du fichier
            return res; // Dispose() est appélé automatiquement au return
        }
    }
}
