using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Model;

namespace Gestion_Stock
{
    public partial class Form_Entree : Form
    {
        public Form_Entree()
        {
            InitializeComponent();
        }

        private void but_enr_tva_Click(object sender, EventArgs e)
        {
            Entree ent = new Entree(Convert.ToInt32(textBox2.Text),textBox1.Text);
            EntreeRepository.EntreeProduit(ent);
            this.Dispose();
        }
    }
}
