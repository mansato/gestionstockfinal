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
    public partial class Form_Famille : Form
    {
        public Form_Famille()
        {
            InitializeComponent();
        }
        public string famille;
        private void but_enr_fam_Click(object sender, EventArgs e)
        {
            Famille fam = new Famille(textBox2.Text,textBox3.Text);
            FamilleRepository.ajoutfamille(fam);
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Famille fam = new Famille(textBox2.Text, textBox3.Text);
            
            FamilleRepository.updatefamille(fam,famille);
            this.Dispose();
        }
    }
}
