using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto.Models
{
    public class Plats : Section
    {
        public Plats()
        {
            Nom = "Plats";
            Produits = new List<Produit>
            {
                new Produit{ Nom = "Penne aux cambas", Prix = 12.50},
                new Produit{ Nom = "Pizza Capriosa", Prix = 14.00},
                new Produit{ Nom = "Pièce du boucher", Prix = 17.50},
                new Produit{ Nom = "Grande salade César", Prix = 8.20},
                new Produit{ Nom = "Pavé de Saumon à la provencale", Prix = 15.20},
            };
        }
    }
}