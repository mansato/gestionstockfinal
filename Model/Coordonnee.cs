using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Coordonnee
    {
        public int id_coordonnee { get; set; }
        public Mail mail { get; set; }
        public Adresse adresse { get; set; }
        public Telephone tel { get; set; }

        public Coordonnee()
        {
            mail = new Mail();
            adresse = new Adresse();
            tel = new Telephone();
        }
        public Coordonnee( Mail M, Adresse A, Telephone T)
        {
            mail = new Mail();
            adresse = new Adresse();
            tel = new Telephone();
            this.mail = M;
            this.adresse = A;
            this.tel = T;
        }
        public Coordonnee(int id, Mail M, Adresse A,Telephone T)
        {
            mail = new Mail();
            adresse = new Adresse();
            tel = new Telephone();
            this.id_coordonnee = id;
            this.mail = M;
            this.adresse = A;
            this.tel = T;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
