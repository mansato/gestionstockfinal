using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Adresse
    {
        public int id_adresse { get; set; }
        public int num_rue { get; set; }
        public string rue { get; set; }
        public string ville { get; set; }
        public string code_postal { get; set; }

        public Adresse() { }

        public Adresse(int id)
        {
            this.id_adresse = id;
        }
        public Adresse(int id, int numrue, string r, string v, string cp)
        {
            this.id_adresse = id;
            this.num_rue = numrue;
            this.rue = r;
            this.ville = v;
            this.code_postal = cp;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }


}
