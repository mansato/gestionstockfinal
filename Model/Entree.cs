using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Entree
    {
        public int id_entree { get; set; }
        public int qte_entree { get; set; }
        public DateTime date_entree { get; set; }
        public string id_prod { get; set; }


        public Entree() { }

        public Entree(int qte, string prod)
        {
           
            this.qte_entree = qte;
            this.id_prod = prod;
        }
        public Entree(int qte, DateTime date, string prod)
        {

            this.qte_entree = qte;
            this.id_prod = prod;
            this.date_entree = date;
        }

        public Entree(int id, int qte, DateTime date,string prod)
        {
            this.id_entree = id;
            this.qte_entree = qte;
            this.date_entree = date;
            this.id_prod = prod;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
