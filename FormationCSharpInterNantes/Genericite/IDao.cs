using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCSharpInterNantes.Genericite
{
    // Type générique est defini dans IDao<TTable> donc IDao<TTable, Tcle>; ça pouvait être TableCle ... rien avoir avec Tcle
    // de TableBase

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TTable"></typeparam>
    /// <typeparam name="Tcle"></typeparam>
    internal interface IDao<TTable, Tcle> where TTable : TableBase<Tcle> // IDao<TTable, Tcle> générique qui utilise une autre générique
    {
        // TTable peut être remplacé par int par exemple mais ici TTable veut dire 
        // je ne connais avance le type
        List<TTable> GetAll();

        int Insert(TTable obj);

        // Je vais donc avoir une table la table produit par exemple donc on crée la table Produit
        // On crée aussi un DAO Générique ici ProduitDa oqui va implementer IDao de type produit 
    }
}
