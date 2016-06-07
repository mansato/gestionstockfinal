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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView_tva.DefaultCellStyle.Font = new Font("Tahoma", 25);
            this.dataGridView_Stock.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView_famille.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView_Fourni.DefaultCellStyle.Font = new Font("Tahoma", 12);
            datagridfournis(0);
            datagridfami(0);
            datagridtva(0);
        }
        public void datagridentree()
        {
            foreach (var item in EntreeRepository.listeent())
            {
                dataGridView_entree.Rows.Add(item.id_prod,item.qte_entree,item.date_entree);
            }

        }
        public void datagridsortie()
        {
            foreach (var item in SortieRepository.listeSort())
            {
                dataGridView_sortie.Rows.Add(item.id_prod, item.qte_sortie, item.date_sortie);
            }
        }
        public void datagridstock(int Nb_Art, decimal capital,int i)
        {
            label_Montant_Capital_Stock.Text = Convert.ToString(0);
            foreach (var item in ProduitRepository.listeProduit())
            {
                dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni,item.tva.montant, item.qte_stock, item.stock_ale);
                Nb_Art++;
                i++;
                label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                if (item.qte_stock < item.stock_ale)
                {
                    dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                }
            }
        }
        public void datagridfournis(int Nb_Art)
        {
            foreach (var item in FournisseurRepository.listefourni())
            {
                dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                Nb_Art++;
                label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
            }
        }
        public void datagridtva(int Nb_Art)
        {
            foreach (var item in TvaRepository.listeTva())
            {
                dataGridView_tva.Rows.Add(item.id_tva, item.montant);
                Nb_Art++;
                label_tva.Text = Convert.ToString(Nb_Art);
            }
        }
        public void datagridfami(int Nb_Art)
        {
            foreach (var item in FamilleRepository.listeFama())
            {
                dataGridView_famille.Rows.Add(item.famille,item.description);
                Nb_Art++;
                label_nb_famille.Text = Convert.ToString(Nb_Art);
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {  
            datagridstock(0,0,-1);
            datagridentree();
            datagridsortie();



        }

        private void button_Add_Stock_Click(object sender, EventArgs e)
        {
            Form_Art Form_art = new Form_Art();
            Form_art.Show();
            Form_art.Disposed += new System.EventHandler(Form_Disposed);
        }

        private void Form_Disposed(object sender, EventArgs e)
        {
            this.dataGridView_Stock.Rows.Clear();
            this.dataGridView_entree.Rows.Clear();
            this.dataGridView_sortie.Rows.Clear();
            this.dataGridView_famille.Rows.Clear();
            this.dataGridView_Fourni.Rows.Clear();
            this.dataGridView_tva.Rows.Clear();
            datagridstock(0,0,-1);
            datagridentree();
            datagridsortie();
            datagridfournis(0);
            datagridfami(0);
            datagridtva(0);
        }

        private void button_Modif_Stock_Click(object sender, EventArgs e)
        {
            Form_Art Form_art = new Form_Art();
            Form_art.Show();
            Form_art.Disposed += new System.EventHandler(Form_Disposed);
            Form_art.label1.Text = "         Modifier Article";
            int index = dataGridView_Stock.CurrentRow.Index;
            Form_art.comboBox_fam_art.Text = dataGridView_Stock[0, index].Value.ToString();
            Form_art.textBox_ref.Text = dataGridView_Stock[1, index].Value.ToString();
            Form_art.textBox_design.Text= dataGridView_Stock[2, index].Value.ToString();
            Form_art.comboBox_four_art.Text= dataGridView_Stock[3, index].Value.ToString();
            Form_art.textBox_prixu.Text= dataGridView_Stock[4, index].Value.ToString();
            Form_art.textBox_qte.Text = dataGridView_Stock[6, index].Value.ToString();
            Form_art.textBox_qta.Text= dataGridView_Stock[7, index].Value.ToString();
            Form_art.comboBox_Tva.Text = dataGridView_Stock[5, index].Value.ToString();
            Form_art.textBox_qte.Enabled = false;
            Form_art.textBox_ref.Enabled = false;
            Form_art.button_enreg_art.Visible = false;
            Form_art.button_annu_art.Visible = false;
            Form_art.button_enregistre_mod.Visible = true;
            



        }

        private void dataGridView_Stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView_Stock.CurrentRow.Index;
        }

        private void button_add_tva_Click(object sender, EventArgs e)
        {
            Form_TVA Form_tva = new Form_TVA();
            Form_tva.Show();
            Form_tva.Disposed += new System.EventHandler(Form_Disposed);
            Form_tva.button1.Visible = false;
        }

        private void button_mod_tva_Click(object sender, EventArgs e)
        {
            Form_TVA Form_tva = new Form_TVA();
            Form_tva.Show();
            Form_tva.label1.Text = "Modifier Tva";
            Form_tva.Disposed += new System.EventHandler(Form_Disposed);
            int index = dataGridView_tva.CurrentRow.Index;
            Form_tva.textBox1.Text = dataGridView_tva[0, index].Value.ToString();
            Form_tva.textBox2.Text = dataGridView_tva[1, index].Value.ToString();
            Form_tva.but_enr_tva.Visible = false;
            Form_tva.but_ann_tva.Visible = false;
        }

        private void button_add_famille_Click(object sender, EventArgs e)
        {
            Form_Famille Form_fam = new Form_Famille();
            Form_fam.Show();
            Form_fam.Disposed += new System.EventHandler(Form_Disposed);
            Form_fam.button1.Visible = false;
        }

        private void button_modifier_famille_Click(object sender, EventArgs e)
        {
            Form_Famille Form_fam = new Form_Famille();
            Form_fam.Show();
            Form_fam.label1.Text = "Modifier Famille";
            Form_fam.Disposed += new System.EventHandler(Form_Disposed);
            int index = dataGridView_famille.CurrentRow.Index;
            Form_fam.textBox2.Text = dataGridView_famille[0, index].Value.ToString();
            Form_fam.textBox3.Text = dataGridView_famille[1, index].Value.ToString();
            Form_fam.famille = dataGridView_famille[0, index].Value.ToString();
            Form_fam.but_enr_fam.Visible = false;
            Form_fam.but_ann_fam.Visible = false;
        }

        private void button_Add_Fourni_Click(object sender, EventArgs e)
        {
            Form_Fournisseur Form_Fourni = new Form_Fournisseur();
            Form_Fourni.Show();
            Form_Fourni.Disposed += new System.EventHandler(Form_Disposed);
            Form_Fourni.button1.Visible = false;

        }

        private void button_Mod_Fourni_Click(object sender, EventArgs e)
        {
            Form_Fournisseur Form_Fourni = new Form_Fournisseur();
            Form_Fourni.Show();
            Form_Fourni.label1.Text = "Modifier Fournisseur";
            Form_Fourni.Disposed += new System.EventHandler(Form_Disposed);
            int index = dataGridView_Fourni.CurrentRow.Index;
            Form_Fourni.textBox1.Text = dataGridView_Fourni[0, index].Value.ToString();
            Form_Fourni.textBox2.Text = dataGridView_Fourni[1, index].Value.ToString();
            Form_Fourni.textBox3.Text = dataGridView_Fourni[2, index].Value.ToString();
            Form_Fourni.textBox4.Text = dataGridView_Fourni[3, index].Value.ToString();
            Form_Fourni.textBox5.Text = dataGridView_Fourni[4, index].Value.ToString();
            Form_Fourni.textBox7.Text = dataGridView_Fourni[5, index].Value.ToString();
            Form_Fourni.textBox6.Text = dataGridView_Fourni[6, index].Value.ToString();
            Form_Fourni.but_enr_four.Visible = false;
            Form_Fourni.but_ann_four.Visible = false;
            Fournisseur four = new Fournisseur(dataGridView_Fourni[0, index].Value.ToString());
             foreach (var item in FournisseurRepository.listefour(four))
            {
                Form_Fourni.fournis = item.id_fournisseur;
                Form_Fourni.addresse = item.coordonnee.adresse.id_adresse;
                Form_Fourni.tele = item.coordonnee.tel.id_tel;
                Form_Fourni.mail = item.coordonnee.mail.id_mail;
            }
        }

        private void dataGridView_tva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Alarme_Stock_Click(object sender, EventArgs e)
        {
            this.dataGridView_Stock.Rows.Clear();
            datagridstock(0, 0,-1);
        }

        private void dataGridView_entree_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Entree_Stock_Click(object sender, EventArgs e)
        {
            Form_Entree Form_Entree = new Form_Entree();
            Form_Entree.Show();
            int index = dataGridView_Stock.CurrentRow.Index;
            Form_Entree.textBox1.Text = dataGridView_Stock[1, index].Value.ToString();
            Form_Entree.Disposed += new System.EventHandler(Form_Disposed);
        }

        private void button_Sortie_Stock_Click(object sender, EventArgs e)
        {
            Form_Sortie Form_Sortie = new Form_Sortie();
            Form_Sortie.Show();
            int index = dataGridView_Stock.CurrentRow.Index;
            Form_Sortie.textBox1.Text = dataGridView_Stock[1, index].Value.ToString();
            Form_Sortie.Disposed += new System.EventHandler(Form_Disposed);
        }
        private void comboBox_Trier_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_Valeur_Stock_TextChanged(object sender, EventArgs e)
        {
            int Nb_Art = 0;
            decimal capital = 0;
            int i = -1;
            switch (comboBox_Champ_Stock.SelectedIndex)
            {
                case 0:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string a = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille
                                 join produit on famille.id_famille = produit.id_famille 
                                 join fournir on fournir.id_produit = produit.id_produit 
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis 
                                 join tva on tva.id_tva = produit.id_tva  
                                 where nom_famille like '%" + textBox_Valeur_Stock.Text + "%' order by nom_famille";
                    List<Produit> list_produit = ProduitRepository.lireproduit(a);
                    label_Montant_Capital_Stock.Text = Convert.ToString(0);
                    foreach (var item in list_produit)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 1:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string b = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille 
                                 join fournir on fournir.id_produit = produit.id_produit 
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis 
                                 join tva on tva.id_tva = produit.id_tva 
                                 where produit.id_produit like '" + textBox_Valeur_Stock.Text + "%' order by id_produit";
                    List<Produit> list_produit1 = ProduitRepository.lireproduit(b);
                    label_Montant_Capital_Stock.Text = Convert.ToString(0);
                    foreach (var item in list_produit1)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 2:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string c = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 where libelle like '%" + textBox_Valeur_Stock.Text + "%' order by libelle";
                    List<Produit> list_produit2 = ProduitRepository.lireproduit(c);
                    foreach (var item in list_produit2)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 3:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string d = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 where nom_fournis like '" + textBox_Valeur_Stock.Text + "%' order by nom_fournis";
                    List<Produit> list_produit3 = ProduitRepository.lireproduit(d);
                    foreach (var item in list_produit3)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 4:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string k = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 where prix_unitaire like '" + textBox_Valeur_Stock.Text + "%' order by prix_unitaire";
                    List<Produit> list_produit4 = ProduitRepository.lireproduit(k);
                    foreach (var item in list_produit4)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }
                    
                    break;
                case 5:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string f = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 where montant like '" + textBox_Valeur_Stock.Text + "%' order by montant";
                    List<Produit> list_produit5 = ProduitRepository.lireproduit(f);
                    foreach (var item in list_produit5)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }
                    
                    break;
                case 6:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string g = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 where qte like '" + textBox_Valeur_Stock.Text + "%' order by qte";
                    List<Produit> list_produit6 = ProduitRepository.lireproduit(g);
                    foreach (var item in list_produit6)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 7:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string h = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 where qte_stock_alerte like '" + textBox_Valeur_Stock.Text + "%' order by qte_stock_alerte";
                    List<Produit> list_produit7 = ProduitRepository.lireproduit(h);
                    foreach (var item in list_produit7)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
               default:
                    break;
            }
        }

        private void button_Del_Stock_Click(object sender, EventArgs e)
        {
            int index = dataGridView_Stock.CurrentRow.Index;
            string valeur = dataGridView_Stock[1, index].Value.ToString();
            ProduitRepository.deleteproduit(valeur);
            dataGridView_Stock.Rows.Clear();
            dataGridView_entree.Rows.Clear();
            dataGridView_sortie.Rows.Clear();
            datagridstock(0, 0, -1);
            datagridentree();
            datagridsortie();
        }

        private void comboBox_Trier_Stock_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int Nb_Art = 0;
            decimal capital = 0;
            int i = -1;
            switch (comboBox_Trier_Stock.SelectedIndex)
            {
                case 0:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string a = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille
                                 join produit on famille.id_famille = produit.id_famille 
                                 join fournir on fournir.id_produit = produit.id_produit 
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis 
                                 join tva on tva.id_tva = produit.id_tva  
                                 order by nom_famille";
                    List<Produit> list_produit = ProduitRepository.lireproduit(a);
                    label_Montant_Capital_Stock.Text = Convert.ToString(0);
                    foreach (var item in list_produit)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 1:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string b = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille 
                                 join fournir on fournir.id_produit = produit.id_produit 
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis 
                                 join tva on tva.id_tva = produit.id_tva 
                                 order by id_produit";
                    List<Produit> list_produit1 = ProduitRepository.lireproduit(b);
                    label_Montant_Capital_Stock.Text = Convert.ToString(0);
                    foreach (var item in list_produit1)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 2:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string c = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 order by libelle";
                    List<Produit> list_produit2 = ProduitRepository.lireproduit(c);
                    foreach (var item in list_produit2)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 3:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string d = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 order by nom_fournis";
                    List<Produit> list_produit3 = ProduitRepository.lireproduit(d);
                    foreach (var item in list_produit3)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 4:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string k = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 order by prix_unitaire";
                    List<Produit> list_produit4 = ProduitRepository.lireproduit(k);
                    foreach (var item in list_produit4)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 5:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string f = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 order by montant";
                    List<Produit> list_produit5 = ProduitRepository.lireproduit(f);
                    foreach (var item in list_produit5)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                case 6:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string g = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                 order by qte";
                    List<Produit> list_produit6 = ProduitRepository.lireproduit(g);
                    foreach (var item in list_produit6)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }

                    break;
                 case 7:
                    dataGridView_Stock.Rows.Clear();
                    label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                    label_Montant_Capital_Stock.Text = Convert.ToString(capital);
                    string h = @"select produit.id_produit, libelle, prix_unitaire, qte, qte_stock_alerte,famille.id_famille,tva.id_tva,nom_famille,fournisseur.id_fournis,nom_fournis,montant from famille 
                                 join produit on famille.id_famille = produit.id_famille
                                 join fournir on fournir.id_produit = produit.id_produit
                                 join fournisseur on fournir.id_fournis = fournisseur.id_fournis
                                 join tva on tva.id_tva = produit.id_tva
                                order by qte_stock_alerte";
                    List<Produit> list_produit7 = ProduitRepository.lireproduit(h);
                    foreach (var item in list_produit7)
                    {
                        dataGridView_Stock.Rows.Add(item.fam.famille, item.codart, item.libelle, item.fournisseur.nom_fournisseur, item.pri_uni, item.tva.montant, item.qte_stock, item.stock_ale);
                        Nb_Art++;
                        i++;
                        label_Nb_Art_Stock.Text = Convert.ToString(Nb_Art);
                        capital = Convert.ToDecimal(label_Montant_Capital_Stock.Text);
                        label_Montant_Capital_Stock.Text = Convert.ToString(capital + (item.pri_uni * item.qte_stock));
                        if (item.qte_stock < item.stock_ale)
                        {
                            dataGridView_Stock.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void button_del_tva_Click(object sender, EventArgs e)
        {
            int index = dataGridView_tva.CurrentRow.Index;
            int valeur =Convert.ToInt32(dataGridView_tva[0, index].Value);
            TvaRepository.deletetva(valeur);
            dataGridView_tva.Rows.Clear();
            datagridtva(0);
        }

        private void button_del_famille_Click(object sender, EventArgs e)
        {
            int index = dataGridView_famille.CurrentRow.Index;
            string valeur = dataGridView_famille[0, index].Value.ToString();
            FamilleRepository.deletetva(valeur);
            dataGridView_famille.Rows.Clear();
            datagridfami(0);
        }

        private void button_Del_Fourni_Click(object sender, EventArgs e)
        {
            int index = dataGridView_Fourni.CurrentRow.Index;
            Fournisseur four = new Fournisseur(dataGridView_Fourni[0, index].Value.ToString());
            foreach (var item in FournisseurRepository.listefour(four))
            {
                int fournis = item.id_fournisseur;
                int addresse = item.coordonnee.adresse.id_adresse;
                int tele = item.coordonnee.tel.id_tel;
                int mail = item.coordonnee.mail.id_mail;
            Telephone tel = new Telephone(tele);
            Adresse add = new Adresse(addresse);
            Mail email = new Mail(mail);
            Coordonnee coor = new Coordonnee(email, add, tel);
            Fournisseur fourni = new Fournisseur(fournis,coor);
            FournisseurRepository.deletefourni(fourni);
            }
            dataGridView_Fourni.Rows.Clear();
            datagridfournis(0);

        }

        private void button_del_entree_Click(object sender, EventArgs e)
        {
            int index = dataGridView_entree.CurrentRow.Index;
            Entree ent = new Entree(Convert.ToInt32(dataGridView_entree[1, index].Value),Convert.ToDateTime(dataGridView_entree[2, index].Value),dataGridView_entree[0, index].Value.ToString());
            EntreeRepository.deleteEntree(ent);
            dataGridView_entree.Rows.Clear();
            dataGridView_Stock.Rows.Clear();
            datagridentree();
            datagridstock(0, 0, -1);
        }

        private void button_del_sortie_Click(object sender, EventArgs e)
        {
            int index = dataGridView_sortie.CurrentRow.Index;
            Sortie sort = new Sortie(Convert.ToInt32(dataGridView_sortie[1, index].Value), Convert.ToDateTime(dataGridView_sortie[2, index].Value), dataGridView_sortie[0, index].Value.ToString());
            SortieRepository.deleteSortie(sort);
            dataGridView_sortie.Rows.Clear();
            dataGridView_Stock.Rows.Clear();
            datagridsortie();
            datagridstock(0, 0, -1);
        }

        private void button_Mult_Stock_Click(object sender, EventArgs e)
        {
            this.dataGridView_Stock.Rows.Clear();
            datagridstock(0, 0, -1);
            textBox_Valeur_Stock.Text = "";
            comboBox_Champ_Stock.Text = "";
        }

        private void button_ok_entree_Click(object sender, EventArgs e)
        {
            dataGridView_entree.Rows.Clear();
           List<Entree> list_entree = EntreeRepository.liredatent(dateTimePicker_debu_entree.Value.Date.ToString("yyyyMMdd 00:00:00"), dateTimePicker_fin_entree.Value.Date.ToString("yyyyMMdd 23:59:59"));
            foreach (var item in list_entree)
            {
                dataGridView_entree.Rows.Add(item.id_prod, item.qte_entree, item.date_entree);
            }

        }

        private void button_ok_sortie_Click(object sender, EventArgs e)
        {
            dataGridView_sortie.Rows.Clear();
            List<Sortie> list_sort = SortieRepository.liredatsort(dateTimePicker_debu_sortie.Value.Date.ToString("yyyyMMdd 00:00:00"), dateTimePicker_fin_sortie.Value.Date.ToString("yyyyMMdd 23:59:59"));
            foreach (var item in list_sort)
            {
                dataGridView_sortie.Rows.Add(item.id_prod, item.qte_sortie, item.date_sortie);
            }
        }

        private void textBox_Valeur_Fourni_TextChanged(object sender, EventArgs e)
        {   int Nb_Art = 0;
            switch (comboBox_Champ_Fourni.SelectedIndex)
            {   
                case 0:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string a = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where nom_fournis like '" + textBox_Valeur_Fourni.Text + "%' order by nom_fournis";
                    List<Fournisseur> list_fourni = FournisseurRepository.lirerouni(a);
                    foreach (var item in list_fourni)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                case 1:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string b = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where num_rue like '" + textBox_Valeur_Fourni.Text + "%' order by  num_rue";
                    List<Fournisseur> list_fourni1 = FournisseurRepository.lirerouni(b);
                    foreach (var item in list_fourni1)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                case 2:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string c = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where rue like '%" + textBox_Valeur_Fourni.Text + "%' order by rue";
                    List<Fournisseur> list_fourni2 = FournisseurRepository.lirerouni(c);
                    foreach (var item in list_fourni2)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                case 3:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string d = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where ville like '" + textBox_Valeur_Fourni.Text + "%' order by ville";
                    List<Fournisseur> list_fourni3 = FournisseurRepository.lirerouni(d);
                    foreach (var item in list_fourni3)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                case 4:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string i = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where cp like '" + textBox_Valeur_Fourni.Text + "%' order by cp";
                    List<Fournisseur> list_fourni4 = FournisseurRepository.lirerouni(i);
                    foreach (var item in list_fourni4)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                case 5:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string f = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where mail like '" + textBox_Valeur_Fourni.Text + "%' order by mail";
                    List<Fournisseur> list_fourni5 = FournisseurRepository.lirerouni(f);
                    foreach (var item in list_fourni5)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                case 6:
                    dataGridView_Fourni.Rows.Clear();
                    label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    string g = @"select nom_fournis,num_rue,rue,ville,cp,telephone,mail from fournisseur
                                 join coordonnee
                                 on fournisseur.id_coordonnee = coordonnee.id_coordonnee
                                 join adresse
                                 on adresse.id_adresse = coordonnee.id_adresse
                                 join telephone
                                 on telephone.id_telephone = coordonnee.id_telephone
                                 join mail
                                 on mail.id_mail = coordonnee.id_mail
                                 where telephone like '" + textBox_Valeur_Fourni.Text + "%' order by telephone";
                    List<Fournisseur> list_fourni6 = FournisseurRepository.lirerouni(g);
                    foreach (var item in list_fourni6)
                    {
                        dataGridView_Fourni.Rows.Add(item.nom_fournisseur, item.coordonnee.adresse.num_rue, item.coordonnee.adresse.rue, item.coordonnee.adresse.ville, item.coordonnee.adresse.code_postal, item.coordonnee.mail.mail, item.coordonnee.tel.telephone);
                        Nb_Art++;
                        label_Nb_Fourni.Text = Convert.ToString(Nb_Art);
                    }
                    break;
                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Filtre_Stock_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_Champ_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
