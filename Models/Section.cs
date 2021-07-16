using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto.Models
{
    public class Section
    {
        public string Nom { get; set; }

        public List<Produit> Produits { get; set; }

        public Section()
        {
            Produits = new List<Produit>();
        }
    }
}