using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.EntiteVsObjetValeur
{
    internal class Entreprise : IComparable<Entreprise>
    {
        public int? Id { get; set; } // On met id nullable int? dans le cas ou le framwork nous génère Id 

        public string Nom { get; set; }

        public Geolocalisation Localisation { get; set; }

        public Entreprise(int? id, string nom, Geolocalisation localisation)
        {
            Id = id;
            Nom = nom;
            Localisation = localisation;
        }

        public int CompareTo(Entreprise? other)
        {
            return Nom.CompareTo(other?.Nom);
        }

        public int CompareParLocalisation(Entreprise other)
        {
            return Localisation.CompareTo(other.Localisation);
        }

        public override bool Equals(object? obj)
        {
            return obj is Entreprise e && Id == e.Id; // Si obj is Entreprise est faux on continu pas && Id == e.Id ne sera pas executée
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();

        }
    }
}
