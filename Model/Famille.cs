 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Famille
    {
        public int id_famille { get; set; }
        public string famille { get; set; }
        public string description { get; set; }

        public Famille()
        { }

        public Famille(string f)
        {
            this.famille = f;

        }

        public Famille(string f,string d)
        {
            this.famille = f;
            this.description = d;
        }


        public Famille(int id, string f,string d)
        {
            this.id_famille = id;
            this.famille = f;
            this.description = d;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
