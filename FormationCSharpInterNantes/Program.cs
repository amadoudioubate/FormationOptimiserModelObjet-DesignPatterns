// See https://aka.ms/new-console-template for more information
using FormationCSharpInterNantes.Genericite;

Console.WriteLine("Hello, World!");

#region Généricité

// Je vais créer mon DAO pour accéder à mon produit on peut mettre var si on v pas spécifier le type
// Pour 
//var produitDao = new();
//ProduitDao produitDao = new();
IDao<Produit> iproduitdao = new ProduitDao();

iproduitdao.GetAll();


#endregion