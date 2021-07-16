using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto.Models
{
    public class Boissons : Section
    {
        public Boissons()
        {
            Nom = "Boissons";
            Produits = new List<Produit>
            {
                new Produit{ Nom = "Coca-cola 33cl", Prix = 2.00},
                new Produit{ Nom = "Orangina 33cl", Prix = 2.00},
                new Produit{ Nom = "Perrier 33cl", Prix = 1.50},
                new Produit{ Nom = "Vittel 1L", Prix = 1.00},
                new Produit{ Nom = "Leffe Blonde 25cl", Prix = 3.20},
                new Produit{ Nom = "Leffe Ruby 25cl", Prix = 3.20},
            };
        }
    }
}