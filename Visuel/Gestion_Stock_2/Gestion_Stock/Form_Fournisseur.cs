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
    public partial class Form_Fournisseur : Form
    {
        public Form_Fournisseur()
        {
            InitializeComponent();
        }
        public int fournis;
        public int mail;
        public int tele;
        public int addresse;
        private void but_enr_four_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void but_enr_four_Click_1(object sender, EventArgs e)
        {
            Telephone tel = new Telephone(tele, textBox6.Text);
            Adresse add = new Adresse(addresse, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text);
            Mail email = new Mail(mail, textBox7.Text);
            Coordonnee coor = new Coordonnee(email, add, tel);
            Fournisseur four = new Fournisseur(fournis, textBox1.Text, coor);
            FournisseurRepository.ajoutfourni(four);
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telephone tel = new Telephone(tele,textBox6.Text);
            Adresse add = new Adresse(addresse,Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text,textBox5.Text);
            Mail email = new Mail(mail,textBox7.Text);
            Coordonnee coor = new Coordonnee(email,add,tel);
            Fournisseur four = new Fournisseur(fournis, textBox1.Text, coor);
            FournisseurRepository.updatefourni(four);
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
