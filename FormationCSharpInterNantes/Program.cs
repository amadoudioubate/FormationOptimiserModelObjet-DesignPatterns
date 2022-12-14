// See https://aka.ms/new-console-template for more information
using FormationCSharpInterNantes.Aggregation;
using FormationCSharpInterNantes.Aggregation.AggregationFaible;
using FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability;
using FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple2;
using FormationCSharpInterNantes.DesignPatterns.Structure.Adapter;
using FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Abstraction;
using FormationCSharpInterNantes.DesignPatterns.Structure.Bride.Implementation;
using FormationCSharpInterNantes.DesignPatterns.Structure.Decorator;
using FormationCSharpInterNantes.DesignPatterns.Structure.Proxy;
using FormationCSharpInterNantes.Encapsulation;
using FormationCSharpInterNantes.EntiteVsObjetValeur;
using FormationCSharpInterNantes.Genericite;
using static FormationCSharpInterNantes.DesignPatterns.Comportement.ChainOfResponsability.Plainte;
//using FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1;
using ProduitObserver = FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1.Produit; // Alias using pour renommer Produit par ProduitObserver pour resoudre le pb de conflit car on a deux classe Produit dans le projet
using ContactObserver = FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple2.Contact;

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

#region Design Patterns - Adapter
Console.WriteLine("\n********************** Design Patterns - Adapter ****************************\n");

//IJsonAdapter adapter = new JsonAdapter(new ContactRepository());
//string json = adapter.RecupererContactJson("contacts.xml");

#endregion

#region Design Patterns - Bride (Pont)
Console.WriteLine("\n********************** Design Patterns - Bride (Pont) ****************************\n");

IAppareil tv = new TV();
var telecommande = new TelecommandeBasique(tv);
telecommande.ChangerCanal(2);
telecommande.DefinirAppaeil(new Radio());

#endregion

#region Design Patterns - Decorator
Console.WriteLine("\n********************** Design Patterns - Decorator ****************************\n");

IVoiture voiture = new VoitureBasique();
voiture.Assembler();
Console.WriteLine("---------------");


voiture = new SportDecorator(voiture);
voiture.Assembler();
Console.WriteLine("---------------");

voiture = new LuxeDecorator(voiture);
voiture.Assembler();
Console.WriteLine("---------------");

// Autre solution

IVoiture voitureLuxeSport = new LuxeDecorator(new SportDecorator(new VoitureBasique()));
voitureLuxeSport.Assembler();

#endregion

#region Design Patterns - Proxy
Console.WriteLine("\n********************** Design Patterns - Proxy ****************************\n");

// Sans passer par le proxy
IMessage message = new MessageUtilisateur("Bonjour");
Console.WriteLine(message.RecupererContenu());


// En passant par le proxy
IMessage messageProxy = new ProxyMessage(new MessageUtilisateur("Bonjour"));
Console.WriteLine(message.RecupererContenu());

#endregion

#region Design Patterns - Chain Of Responsability

Console.WriteLine("\n************************* Design Patterns - Chain Of Responsability *****************************\n");
// La chaine d'objets qui va traiter notre plainte
// Si je mets Formateur ou DirPeda en premier ça ne change rien car on test sur eux
// Si le formateur voit que req type == 2 , il passe à son successeur DirPeda et inverssement 
// Le directeur doit être forcement le dernier de la chaine car on ne fait pas de test sur lui
MembreEquipe chaine = new Formateur("Florian", new DirPeda("Deny", new Directeur("Jérome", null)));

Console.WriteLine("\n-------------- REQ 1 -----------------\n");
chaine.Handle(new Plainte(123, 1, "req1", EtatPlainte.Ouvert));


Console.WriteLine("\n-------------- REQ 2 -----------------\n");
chaine.Handle(new Plainte(124, 2, "req2", EtatPlainte.Ouvert));


Console.WriteLine("\n-------------- REQ 3 -----------------\n");
chaine.Handle(new Plainte(123, 3, "req3", EtatPlainte.Ouvert));

#endregion

#region Design Patterns - Observer 1
Console.WriteLine("\n************************ Design Patterns - Observer 1 *************************\n");
var produit = new ProduitObserver { Description = "RTX 4090", Prix = 2500 };

produit.Attacher(new FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1.Client("Amadou", "dioubateamadou@yahoo.fr"));
produit.Attacher(new FormationCSharpInterNantes.DesignPatterns.Comportement.Observer.Exemple1.Client("Saran", "saransacko95@yahoo.fr"));

// Encapsulation est bien respectée, ici on n'a besoin d'accéder au Prix depuis l'exterieur et en plus on passe par propriété Prix
produit.Prix = 2000;

#endregion

#region Design Patterns - Observer 2
Console.WriteLine("\n************************ Design Patterns - Observer 2 *************************\n");
var article = new Article { Description = "RTX 4090", Prix = 2000 };

IDisposable disC1 = article.Subscribe(new ContactObserver { Nom = "Amadou" });
IDisposable disC2 = article.Subscribe(new ContactObserver { Nom = "Saran" });

article.Prix = 1500; // Le changement déclenche les notifications

disC1.Dispose(); // unsubscribe de C1

article.Prix = 1000;

#endregion

