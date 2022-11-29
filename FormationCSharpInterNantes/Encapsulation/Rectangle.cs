using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Encapsulation
{
    internal class Rectangle
    {
        private double _longueur;
        private double _largeur;
        #region Champs et proprietés
        private double Longueur
        {
            get => _longueur;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("La longueur ne peut pas être négative");
                _longueur = value;
            }
        }
        private double Largeur 
        { 
            get => _largeur; 
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("La largeur ne peut pas être négative");
                //else _largeur = value; else pas obligatoire car si Exception lévée ça stop le programme donc pour optimiser 
                                         // un p mon code on enlève else
                _largeur = value;
            }  
                
        }

        #endregion

        #region Constructeur

        public Rectangle(double longueur, double largeur)
        {
            //Longueur = longueur;
            //Largeur = largeur;
            // Pour optimiser un p mon code on peut utiliser la méthode Redim dans le constructeur pour éviter de repéter
            // le code Longueur = longueur;
            //         Largeur = largeur;
            Redim(longueur, largeur);
        }

        #endregion

        #region Méthodes

        public double Aire()
        {
            return Longueur * Largeur;
        }

        // Pour respecter le principe de l'ancapsulation pour eviter dans le program.cs Longueur = 24, Largeur = 50
        // ça nous permet de mettre les propriétés setter et getter en private
        public void Redim(double longueur, double largeur) 
        {
            Longueur = longueur;
            Largeur = largeur;
        }
        #endregion
    }
}
