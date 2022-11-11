using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_stock.entities
{
    public class Article
    {
        public int num_reference { get; set; }
        public string nom { get; set; }
        public int prix { get; set; }
        public int quantite { get; set; }

        public Article(int num_reference, string nom, int prix, int quantite)
        {
            this.num_reference = num_reference;
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
        }

        public Article()
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
