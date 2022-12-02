using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1
{
    internal class Client : IObservateur
    {
        public int? Id { get; set; } // nullable je ne suis pas obligé de passer un numéro, c'est le framework (ORM) qui va générer automatiquement Id

        public string Nom { get; set; }    

        public string Email { get; set; }

        public Client(string nom, string email)
        {
            Nom = nom;
            Email = email;
        }

        public void MettreAJour(ISujet sujet)
        {
            // TODO => tache à faire
            //TODO 

            // Caster notre interface Isujet en Produit
            var p = sujet as Produit; // (Produit)sujet => avec as soit p va être null ou Produit


            // Debut Envoie Email //
            var corpsMail = $"Bonjour {Nom},\n le prix du produit a été modifié :  {p.Prix}"; // Corps de mon mail

            /*var m = new MailMessage("noreply@dawan.fr",
                Email,
                "Changement de prix du " + p.Description,
                corpsMail);  // MailMessage();

            var client = new SmtpClient("smtp.free.fr");
            client.Credentials = CredentialCache.DefaultNetworkCredentials; // DefaultNetworkCredentials est crypté (Credentials => connexion)
            client.Send(m); */
            // Fin Envoie Email //

            Debug.WriteLine(corpsMail);

        }
    }
}
