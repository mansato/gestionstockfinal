using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Telephone
    {
        public int id_tel { get; set; }
        public string telephone { get; set; }

        public Telephone() { }
        public Telephone(int id)
        {
            this.id_tel = id;
        }
        public Telephone(int id, string tel)
        {
            this.id_tel = id;
            this.telephone = tel;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
