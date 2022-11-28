// See https://aka.ms/new-console-template for more information
using FormationCSharpInterNantes.Genericite;

Console.WriteLine("Hello, World!");

#region Généricité

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

Func<double, double> pow2 = x => Math.Pow(x, 2);
double resP = pow2(23);
Console.WriteLine(resP);










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