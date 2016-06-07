using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sortie
    {
        public int id_sortie { get; set; }
        public int qte_sortie { get; set; }
        public DateTime date_sortie { get; set; }
        public string id_prod { get; set; }


        public Sortie() { }

        public Sortie(int qte, string prod)
        {
        
            this.qte_sortie = qte;
            this.id_prod = prod;
        }
        public Sortie(int qte, DateTime date, string prod)
        {

            this.qte_sortie = qte;
            this.id_prod = prod;
            this.date_sortie = date;
        }
        public Sortie(int id, int qte, DateTime date, string prod)
        {
            this.id_sortie = id;
            this.qte_sortie = qte;
            this.date_sortie = date;
            this.id_prod = prod;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
