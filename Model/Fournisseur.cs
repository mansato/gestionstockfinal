using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fournisseur
    {
        public int id_fournisseur { get; set; }
        public string nom_fournisseur { get; set; }
        public Coordonnee coordonnee { get; set; }


        public Fournisseur(string nom)
        {
           
            this.nom_fournisseur = nom;
        }
        public Fournisseur(int id, Coordonnee coord)
        {
            coordonnee = new Coordonnee();
            this.id_fournisseur = id;
            this.coordonnee = coord;
        }
        public Fournisseur(int id, string nom, Coordonnee coord)
        { coordonnee = new Coordonnee();
            this.id_fournisseur = id;
            this.nom_fournisseur = nom;
            this.coordonnee = coord;
        }

        public Fournisseur()
        {
            coordonnee = new Coordonnee();
                }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
