using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability
{
    internal abstract class MembreEquipe // Handler (dans le schéma UML) => Middleware abstract
    {
        protected string _nom;

        // Pour avoir le membre suivant dans la responsabilité
        protected MembreEquipe _successeur;  // Successeur doit êttre à protected, c'est obligatoire => même type que moi même classe (MembreEquipe)

        protected MembreEquipe(string nom, MembreEquipe successeur)
        {
            _nom = nom;
            _successeur = successeur;
        }

        // Middleware abstract
        // Handle je passe en paramètre l'objet que je vais traiter
        public abstract void Handle(Plainte requete);
    }
}
