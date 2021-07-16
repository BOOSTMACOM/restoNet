using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto.Models
{
    public class Desserts : Section
    {
        public Desserts()
        {
            Nom = "Desserts";
            Produits = new List<Produit>
            {
                new Produit{ Nom = "Mousse au chocolat façon Grand-mère", Prix = 4.15},
                new Produit{ Nom = "Banana Splite", Prix = 5.00},
                new Produit{ Nom = "Coupe glâcée", Prix = 5.50},
                new Produit{ Nom = "Café gourmand", Prix = 7.50},
                new Produit{ Nom = "Farandole de desserts", Prix = 9.20},
            };
        }
    }
}