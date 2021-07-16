using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto.Models
{
    public class Entrees : Section
    {
        public Entrees(){
            Nom = "Entrées";
            Produits = new List<Produit>
            {
                new Produit{ Nom = "Carpaccio de boeuf", Prix = 11.20},
                new Produit{ Nom = "Tartare de boeuf", Prix = 12.50},
                new Produit{ Nom = "Raviolles au gorgonzola", Prix = 7.50},
                new Produit{ Nom = "Petite salade césar", Prix = 5.20},
            };
        }
    }
}