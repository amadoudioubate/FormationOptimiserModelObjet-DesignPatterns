// See https://aka.ms/new-console-template for more information
using FormationCSharpInterNantes.Aggregation;
using FormationCSharpInterNantes.Aggregation.AggregationFaible;
using FormationCSharpInterNantes.Encapsulation;
using FormationCSharpInterNantes.EntiteVsObjetValeur;
using FormationCSharpInterNantes.Genericite;

using System.ComponentModel;

Console.WriteLine("Hello, World!");

#region Généricité

Console.WriteLine("\n********************** GENERICITE ****************************\n");
// Je vais créer mon DAO pour accéder à mon produit on peut mettre var si on v pas spécifier le type
// Pour 
//var produitDao = new();
//ProduitDao produitDao = new();
// Il faut ProduitDao utilise  Produit
// Généricité c'est eviter qu'on passe aussi par object
IDao<Produit, int> iproduitdao = new ProduitDao();

//iproduitdao.GetAll();


#endregion

#region Expressions Lamda
Console.WriteLine("\n********************** EXPRESSIONS LAMDA ****************************\n");
// Thread c'est un fil d'éxécution 
Thread thread = new(() => 
{
    Console.WriteLine("Bonjour depuis le thread 1");
}); // Constructeur qui fourni des paramètres sur lesquels on pourra agir

thread.Start();

var lp = new List<Produit>
{
    new Produit { Id = 1, Description = "RTX 4090", Prix = 2000},
    new Produit { Id = 2, Description = "Balai", Prix = 25}
};

lp.Sort((Produit p1, Produit p2) =>
{
    if(p1.Prix == p2.Prix) return 0;
    else if (p1.Prix < p2.Prix) return -1;
    else return 1;
});
lp.ForEach(p => Console.WriteLine(p.Description + " : " + p.Prix));

// La fonction Func (delegate) prend un paramètre double et retorune un double
// Func prend 17 paramètre au maximum
Func<double, double> pow2 = x => Math.Pow(x, 2);
double resP = pow2(23);
Console.WriteLine(resP);

// Deux paramètres double, double et en sortie un double
Func<double, double, double> pow2Bis = (x1,x2) => Math.Pow(x1, x2);
double resPBis = pow2Bis(23,10);
Console.WriteLine(resPBis);










/*delegate void EcrireConsole(string chaine); // delegate n'a pas de code (delegate c'est comme callback en javascript)

public void Traitement(EcrireConsole callback)
{
    callback("Bonjour");
}

Traitement((c) => Console.WriteLine(c));*/

/*delegate bool Predicat(Produit p); // delegate n'a pas de code (delegate c'est comme callback en javascript)

public bool Find(Predicat callback)
{
    var foubd = false;

    foreach (var produit in produits)
    {
        if (callback(produit))
        {
            foubd = true;
            break;
        }

    }
    return foubd;
}

Find((c) => c.Id == Produit.Id));*/
#endregion

#region Encapsulation
Console.WriteLine("\n********************** ENCAPSULATION ****************************\n");
var r = new Rectangle(12, 36);
//var res = r.Longueur * r.Largeur; // Est ce que j'ai besoin de Largeur ou Longueur individuellement?
// ici non pour respecter le principe de l'encapsulation on crée une méthode Aire()
// Comme je n'ai pas besoin d'inviduellement Longueur et Largeur , je les mets en private, ça m'évitera 
// d'eviter d'exposer la structure interne de mon objet rectangle r
r.Aire();

// Pour respecter le principe de l'ancapsulation pour eviter dans le program.cs Longueur = 24, Largeur = 50
r.Redim(24, 50);

#endregion

#region EntitesVSObjectValeur
Console.WriteLine("\n********************** ENTITES OBJET VALEUR ****************************\n");

var e1 = new Entreprise(1, "Dawan", new Geolocalisation(2.3527, 48.8543));
var e2 = new Entreprise(2, "Jehan", new Geolocalisation(3.37, 48.8543));

int compParNom = e1.CompareTo(e2);
int compParLocalisation = e1.CompareParLocalisation(e2);

List<Entreprise> lstE = new() { e2, e1 };
lstE.Sort();
lstE.ForEach(e => Console.WriteLine(e.Nom));

#endregion


#region Aggregation
Console.WriteLine("\n********************** AGGREGATION ****************************\n");

var v = new Voiture(new Moteur("diesel")); // Aggrégation forte car voiture ne peut pas exister sans moteur
v.Garer(new Parking()); // Association

//v.Moteur.Motorisation = "hydrogène"; // Problème on doit pas changer moteur d'une voiture comme ça
//var v1 = new Voiture { Moteur = new Moteur { Motorisation = "hydrogène" } }; // Constructeur par propriété

var v2 = new Voiture("hydrogène"); // Composition


// Aggregation Faible : Adresse fait partie du client
// Ici client serait une entité et l'adresse un objet de valeur
var client = new Client
{
    Nom = "Doe",
    Prenom = "John",
    Adresse = new()
    {
        Num = 15,
        Rue = "Vincent Gâche"
    }
};
#endregion

#region TP2 Tell Don't ASK 
Console.WriteLine("\n********************** Delivery ****************************\n");



#endregion
Console.ReadKey();
