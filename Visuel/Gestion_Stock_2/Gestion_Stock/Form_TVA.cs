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
    public partial class Form_TVA : Form
    {
        public Form_TVA()
        {
            InitializeComponent();
        }

        private void but_enr_tva_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void but_enr_tva_Click_1(object sender, EventArgs e)
        {
            TVA tva = new TVA(Convert.ToInt16(textBox1.Text), Convert.ToDecimal(textBox2.Text));
            TvaRepository.ajoutTVA(tva);
            this.Dispose();
        }

        private void Form_TVA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TVA tva = new TVA(Convert.ToInt16(textBox1.Text), Convert.ToDecimal(textBox2.Text));
            TvaRepository.ajoutTVA(tva);
            this.Dispose();
        }
    }
}
