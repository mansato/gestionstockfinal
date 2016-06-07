using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mail
    {
        public int id_mail { get; set; }
        public string mail { get; set; }

        public Mail() { }

        public Mail(int id)
        {
            this.id_mail = id;
        }
        public Mail(int id, string email)
        {
            this.id_mail = id;
            this.mail = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
