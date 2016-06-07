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
    public partial class Form_Art : Form
    {
        
        public Form_Art()
        {
            InitializeComponent();
           
        }
       
        private void Form_Art_Load(object sender, EventArgs e)
        {
            foreach (var item in TvaRepository.listeTva())
            {
                comboBox_Tva.Items.Add(item.montant);
            }
            foreach (var item in  FournisseurRepository.listefourni())
            {
                comboBox_four_art.Items.Add(item.nom_fournisseur);
            }
            foreach (var item in FamilleRepository.listeFama())
            {
                comboBox_fam_art.Items.Add(item.famille);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_enreg_art_Click(object sender, EventArgs e)
        {

            TVA tva = new TVA(Convert.ToDecimal(comboBox_Tva.SelectedItem.ToString()));
            Famille fam = new Famille(comboBox_fam_art.SelectedItem.ToString());
            Fournisseur four = new Fournisseur(comboBox_four_art.SelectedItem.ToString());
            Produit produit = new Produit(textBox_ref.Text, textBox_design.Text, Convert.ToDecimal(textBox_prixu.Text), tva, Convert.ToInt32(textBox_qte.Text), Convert.ToInt32(textBox_qta.Text), fam, four);
            ProduitRepository.ajoutProduit(produit);
           this.Dispose();
        }

        private void button_enregistre_mod_Click(object sender, EventArgs e)
        {

            TVA tva = new TVA(Convert.ToDecimal(comboBox_Tva.SelectedItem.ToString()));
            Famille fam = new Famille(comboBox_fam_art.SelectedItem.ToString());
            Fournisseur four = new Fournisseur(comboBox_four_art.SelectedItem.ToString());
            Produit produit = new Produit(textBox_ref.Text, textBox_design.Text, Convert.ToDecimal(textBox_prixu.Text), tva, Convert.ToInt32(textBox_qte.Text), Convert.ToInt32(textBox_qta.Text), fam, four);
            ProduitRepository.updateproduit(produit);
            this.Dispose();
        }
    }
}
