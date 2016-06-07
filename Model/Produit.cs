using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produit
    {
        public string codart { get; set; }
        public string libelle { get; set; }
        public decimal pri_uni { get; set; }
        public TVA tva { get; set; }
        public int qte_stock { get; set; }
        public int stock_ale { get; set; }
        public Famille fam { get; set; }
        public Fournisseur fournisseur { get; set; }
        public Entree entree { get; set; }
        public Sortie sortie { get; set; }

        public Produit(string c, string lib, decimal prix, TVA t, int qte, int ale, Famille fami, Fournisseur four)
        {
            entree = new Entree();
            sortie = new Sortie();
            tva = new TVA();
            fournisseur = new Fournisseur();
            fam = new Famille();
            this.codart = c;
            this.libelle = lib;
            this.pri_uni = prix;
            this.tva = t;
            this.qte_stock = qte;
            this.stock_ale = ale;
            this.fam = fami;
            this.fournisseur = four;
        }

        public Produit(string c, string lib, decimal prix, TVA t, int qte, int ale, Famille fami, Fournisseur four,Entree ent,Sortie sort)
        {
            entree = new Entree();
            sortie = new Sortie();
            tva = new TVA();           
            fournisseur = new Fournisseur();
            fam = new Famille();
            this.codart = c;
            this.libelle = lib;
            this.pri_uni = prix;
            this.tva = t;
            this.qte_stock = qte;
            this.stock_ale = ale;
            this.fam = fami;
            this.fournisseur = four;
            this.sortie = sort;
            this.entree = ent;
        }

        public Produit()
        {
            tva = new TVA();
            fam = new Famille();
            fournisseur = new Fournisseur();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
