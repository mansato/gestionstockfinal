namespace Gestion_Stock
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Montant_Capital_Stock = new System.Windows.Forms.Label();
            this.label_Art_Stock = new System.Windows.Forms.Label();
            this.label_Capital_Stock = new System.Windows.Forms.Label();
            this.label_Nb_Art_Stock = new System.Windows.Forms.Label();
            this.dataGridView_Stock = new System.Windows.Forms.DataGridView();
            this.Famille_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libel_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fourni_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnetva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte_alrt_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Enter_Sortie = new System.Windows.Forms.GroupBox();
            this.button_Entree_Stock = new System.Windows.Forms.Button();
            this.button_Sortie_Stock = new System.Windows.Forms.Button();
            this.groupBox_Filtre_Stock = new System.Windows.Forms.GroupBox();
            this.textBox_Valeur_Stock = new System.Windows.Forms.TextBox();
            this.button_Mult_Stock = new System.Windows.Forms.Button();
            this.comboBox_Champ_Stock = new System.Windows.Forms.ComboBox();
            this.label_Valeur_Stock = new System.Windows.Forms.Label();
            this.label_Fleche_Stock = new System.Windows.Forms.Label();
            this.label_Champ_Stock = new System.Windows.Forms.Label();
            this.groupBox_Trie_Stock = new System.Windows.Forms.GroupBox();
            this.comboBox_Trier_Stock = new System.Windows.Forms.ComboBox();
            this.label_Trier_Stock = new System.Windows.Forms.Label();
            this.button_Del_Stock = new System.Windows.Forms.Button();
            this.button_Modif_Stock = new System.Windows.Forms.Button();
            this.button_Alarme_Stock = new System.Windows.Forms.Button();
            this.button_Add_Stock = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_del_entree = new System.Windows.Forms.Button();
            this.dataGridView_entree = new System.Windows.Forms.DataGridView();
            this.Produit_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_filtre_entree = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_fin_entree = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_debu_entree = new System.Windows.Forms.DateTimePicker();
            this.button_ok_entree = new System.Windows.Forms.Button();
            this.label_valeur_entree = new System.Windows.Forms.Label();
            this.label_fleche_entree = new System.Windows.Forms.Label();
            this.label_filtre_champ_entréé = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_filtre_sortie = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_fin_sortie = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_debu_sortie = new System.Windows.Forms.DateTimePicker();
            this.button_ok_sortie = new System.Windows.Forms.Button();
            this.label_valeur_sortie = new System.Windows.Forms.Label();
            this.label_fleche_sortie = new System.Windows.Forms.Label();
            this.label_champ_sortie = new System.Windows.Forms.Label();
            this.button_del_sortie = new System.Windows.Forms.Button();
            this.dataGridView_sortie = new System.Windows.Forms.DataGridView();
            this.prod_sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_Fourni = new System.Windows.Forms.Label();
            this.label_Nb_Fourni = new System.Windows.Forms.Label();
            this.dataGridView_Fourni = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_filtre_fourni = new System.Windows.Forms.GroupBox();
            this.textBox_Valeur_Fourni = new System.Windows.Forms.TextBox();
            this.comboBox_Champ_Fourni = new System.Windows.Forms.ComboBox();
            this.label_Valeur_Fourni = new System.Windows.Forms.Label();
            this.label_Fleche_Fourni = new System.Windows.Forms.Label();
            this.label_champ_Fourni = new System.Windows.Forms.Label();
            this.button_Del_All_Fourni = new System.Windows.Forms.Button();
            this.button_Del_Fourni = new System.Windows.Forms.Button();
            this.button_Mod_Fourni = new System.Windows.Forms.Button();
            this.button_Add_Fourni = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_nb_tva = new System.Windows.Forms.Label();
            this.label_tva = new System.Windows.Forms.Label();
            this.dataGridView_tva = new System.Windows.Forms.DataGridView();
            this.Id_Tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_del_tva = new System.Windows.Forms.Button();
            this.button_mod_tva = new System.Windows.Forms.Button();
            this.button_add_tva = new System.Windows.Forms.Button();
            this.label_nbf_famille = new System.Windows.Forms.Label();
            this.label_nb_famille = new System.Windows.Forms.Label();
            this.dataGridView_famille = new System.Windows.Forms.DataGridView();
            this.Nom_Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_del_famille = new System.Windows.Forms.Button();
            this.button_modifier_famille = new System.Windows.Forms.Button();
            this.button_add_famille = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).BeginInit();
            this.groupBox_Enter_Sortie.SuspendLayout();
            this.groupBox_Filtre_Stock.SuspendLayout();
            this.groupBox_Trie_Stock.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_entree)).BeginInit();
            this.groupBox_filtre_entree.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_filtre_sortie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sortie)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fourni)).BeginInit();
            this.groupBox_filtre_fourni.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_famille)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_Montant_Capital_Stock);
            this.tabPage1.Controls.Add(this.label_Art_Stock);
            this.tabPage1.Controls.Add(this.label_Capital_Stock);
            this.tabPage1.Controls.Add(this.label_Nb_Art_Stock);
            this.tabPage1.Controls.Add(this.dataGridView_Stock);
            this.tabPage1.Controls.Add(this.groupBox_Enter_Sortie);
            this.tabPage1.Controls.Add(this.groupBox_Filtre_Stock);
            this.tabPage1.Controls.Add(this.groupBox_Trie_Stock);
            this.tabPage1.Controls.Add(this.button_Del_Stock);
            this.tabPage1.Controls.Add(this.button_Modif_Stock);
            this.tabPage1.Controls.Add(this.button_Alarme_Stock);
            this.tabPage1.Controls.Add(this.button_Add_Stock);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_Montant_Capital_Stock
            // 
            this.label_Montant_Capital_Stock.AutoSize = true;
            this.label_Montant_Capital_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Montant_Capital_Stock.Location = new System.Drawing.Point(277, 499);
            this.label_Montant_Capital_Stock.Name = "label_Montant_Capital_Stock";
            this.label_Montant_Capital_Stock.Size = new System.Drawing.Size(18, 20);
            this.label_Montant_Capital_Stock.TabIndex = 17;
            this.label_Montant_Capital_Stock.Text = "0";
            // 
            // label_Art_Stock
            // 
            this.label_Art_Stock.AutoSize = true;
            this.label_Art_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Art_Stock.Location = new System.Drawing.Point(784, 499);
            this.label_Art_Stock.Name = "label_Art_Stock";
            this.label_Art_Stock.Size = new System.Drawing.Size(95, 20);
            this.label_Art_Stock.TabIndex = 16;
            this.label_Art_Stock.Text = "NB.Articles :";
            // 
            // label_Capital_Stock
            // 
            this.label_Capital_Stock.AutoSize = true;
            this.label_Capital_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Capital_Stock.Location = new System.Drawing.Point(198, 499);
            this.label_Capital_Stock.Name = "label_Capital_Stock";
            this.label_Capital_Stock.Size = new System.Drawing.Size(66, 20);
            this.label_Capital_Stock.TabIndex = 15;
            this.label_Capital_Stock.Text = "Capital :";
            // 
            // label_Nb_Art_Stock
            // 
            this.label_Nb_Art_Stock.AutoSize = true;
            this.label_Nb_Art_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nb_Art_Stock.Location = new System.Drawing.Point(879, 499);
            this.label_Nb_Art_Stock.Name = "label_Nb_Art_Stock";
            this.label_Nb_Art_Stock.Size = new System.Drawing.Size(51, 20);
            this.label_Nb_Art_Stock.TabIndex = 13;
            this.label_Nb_Art_Stock.Text = "label1";
            // 
            // dataGridView_Stock
            // 
            this.dataGridView_Stock.AllowUserToAddRows = false;
            this.dataGridView_Stock.AllowUserToDeleteRows = false;
            this.dataGridView_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Stock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Famille_stock,
            this.Ref_stock,
            this.Libel_Stock,
            this.Fourni_stock,
            this.Prix_stock,
            this.colonnetva,
            this.Qte_Stock,
            this.Qte_alrt_stock});
            this.dataGridView_Stock.Location = new System.Drawing.Point(6, 95);
            this.dataGridView_Stock.Name = "dataGridView_Stock";
            this.dataGridView_Stock.ReadOnly = true;
            this.dataGridView_Stock.Size = new System.Drawing.Size(1118, 382);
            this.dataGridView_Stock.TabIndex = 12;
            this.dataGridView_Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Stock_CellContentClick);
            // 
            // Famille_stock
            // 
            this.Famille_stock.HeaderText = "Famille";
            this.Famille_stock.Name = "Famille_stock";
            this.Famille_stock.ReadOnly = true;
            // 
            // Ref_stock
            // 
            this.Ref_stock.HeaderText = "Réference";
            this.Ref_stock.Name = "Ref_stock";
            this.Ref_stock.ReadOnly = true;
            // 
            // Libel_Stock
            // 
            this.Libel_Stock.HeaderText = "Libellé";
            this.Libel_Stock.Name = "Libel_Stock";
            this.Libel_Stock.ReadOnly = true;
            // 
            // Fourni_stock
            // 
            this.Fourni_stock.HeaderText = "Fournisseur";
            this.Fourni_stock.Name = "Fourni_stock";
            this.Fourni_stock.ReadOnly = true;
            // 
            // Prix_stock
            // 
            this.Prix_stock.HeaderText = "PrixU";
            this.Prix_stock.Name = "Prix_stock";
            this.Prix_stock.ReadOnly = true;
            // 
            // colonnetva
            // 
            this.colonnetva.HeaderText = "TVA";
            this.colonnetva.Name = "colonnetva";
            this.colonnetva.ReadOnly = true;
            // 
            // Qte_Stock
            // 
            this.Qte_Stock.HeaderText = "Qte";
            this.Qte_Stock.Name = "Qte_Stock";
            this.Qte_Stock.ReadOnly = true;
            // 
            // Qte_alrt_stock
            // 
            this.Qte_alrt_stock.HeaderText = "Alerte";
            this.Qte_alrt_stock.Name = "Qte_alrt_stock";
            this.Qte_alrt_stock.ReadOnly = true;
            // 
            // groupBox_Enter_Sortie
            // 
            this.groupBox_Enter_Sortie.Controls.Add(this.button_Entree_Stock);
            this.groupBox_Enter_Sortie.Controls.Add(this.button_Sortie_Stock);
            this.groupBox_Enter_Sortie.Location = new System.Drawing.Point(1130, 318);
            this.groupBox_Enter_Sortie.Name = "groupBox_Enter_Sortie";
            this.groupBox_Enter_Sortie.Size = new System.Drawing.Size(106, 134);
            this.groupBox_Enter_Sortie.TabIndex = 11;
            this.groupBox_Enter_Sortie.TabStop = false;
            this.groupBox_Enter_Sortie.Text = "Entrée__Sortie";
            this.groupBox_Enter_Sortie.UseCompatibleTextRendering = true;
            // 
            // button_Entree_Stock
            // 
            this.button_Entree_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Entree_Stock.Location = new System.Drawing.Point(19, 21);
            this.button_Entree_Stock.Name = "button_Entree_Stock";
            this.button_Entree_Stock.Size = new System.Drawing.Size(69, 48);
            this.button_Entree_Stock.TabIndex = 5;
            this.button_Entree_Stock.Text = "Entrée";
            this.button_Entree_Stock.UseVisualStyleBackColor = true;
            this.button_Entree_Stock.Click += new System.EventHandler(this.button_Entree_Stock_Click);
            // 
            // button_Sortie_Stock
            // 
            this.button_Sortie_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sortie_Stock.Location = new System.Drawing.Point(19, 75);
            this.button_Sortie_Stock.Name = "button_Sortie_Stock";
            this.button_Sortie_Stock.Size = new System.Drawing.Size(69, 48);
            this.button_Sortie_Stock.TabIndex = 6;
            this.button_Sortie_Stock.Text = "Sortie";
            this.button_Sortie_Stock.UseVisualStyleBackColor = true;
            this.button_Sortie_Stock.Click += new System.EventHandler(this.button_Sortie_Stock_Click);
            // 
            // groupBox_Filtre_Stock
            // 
            this.groupBox_Filtre_Stock.Controls.Add(this.textBox_Valeur_Stock);
            this.groupBox_Filtre_Stock.Controls.Add(this.button_Mult_Stock);
            this.groupBox_Filtre_Stock.Controls.Add(this.comboBox_Champ_Stock);
            this.groupBox_Filtre_Stock.Controls.Add(this.label_Valeur_Stock);
            this.groupBox_Filtre_Stock.Controls.Add(this.label_Fleche_Stock);
            this.groupBox_Filtre_Stock.Controls.Add(this.label_Champ_Stock);
            this.groupBox_Filtre_Stock.Location = new System.Drawing.Point(373, 27);
            this.groupBox_Filtre_Stock.Name = "groupBox_Filtre_Stock";
            this.groupBox_Filtre_Stock.Size = new System.Drawing.Size(751, 62);
            this.groupBox_Filtre_Stock.TabIndex = 10;
            this.groupBox_Filtre_Stock.TabStop = false;
            this.groupBox_Filtre_Stock.Text = "Filtre";
            this.groupBox_Filtre_Stock.Enter += new System.EventHandler(this.groupBox_Filtre_Stock_Enter);
            // 
            // textBox_Valeur_Stock
            // 
            this.textBox_Valeur_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Valeur_Stock.Location = new System.Drawing.Point(499, 23);
            this.textBox_Valeur_Stock.Name = "textBox_Valeur_Stock";
            this.textBox_Valeur_Stock.Size = new System.Drawing.Size(100, 26);
            this.textBox_Valeur_Stock.TabIndex = 24;
            this.textBox_Valeur_Stock.TextChanged += new System.EventHandler(this.textBox_Valeur_Stock_TextChanged);
            // 
            // button_Mult_Stock
            // 
            this.button_Mult_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mult_Stock.Location = new System.Drawing.Point(650, 22);
            this.button_Mult_Stock.Name = "button_Mult_Stock";
            this.button_Mult_Stock.Size = new System.Drawing.Size(75, 29);
            this.button_Mult_Stock.TabIndex = 23;
            this.button_Mult_Stock.Text = "X";
            this.button_Mult_Stock.UseVisualStyleBackColor = true;
            this.button_Mult_Stock.Click += new System.EventHandler(this.button_Mult_Stock_Click);
            // 
            // comboBox_Champ_Stock
            // 
            this.comboBox_Champ_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Champ_Stock.FormattingEnabled = true;
            this.comboBox_Champ_Stock.Items.AddRange(new object[] {
            "Famille",
            "Réference",
            "Libellé",
            "Fournisseur",
            "PrixU",
            "TVA",
            "Qte",
            "Alerte"});
            this.comboBox_Champ_Stock.Location = new System.Drawing.Point(172, 23);
            this.comboBox_Champ_Stock.Name = "comboBox_Champ_Stock";
            this.comboBox_Champ_Stock.Size = new System.Drawing.Size(184, 28);
            this.comboBox_Champ_Stock.TabIndex = 22;
            this.comboBox_Champ_Stock.SelectedIndexChanged += new System.EventHandler(this.comboBox_Champ_Stock_SelectedIndexChanged);
            // 
            // label_Valeur_Stock
            // 
            this.label_Valeur_Stock.AutoSize = true;
            this.label_Valeur_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valeur_Stock.Location = new System.Drawing.Point(411, 27);
            this.label_Valeur_Stock.Name = "label_Valeur_Stock";
            this.label_Valeur_Stock.Size = new System.Drawing.Size(63, 20);
            this.label_Valeur_Stock.TabIndex = 21;
            this.label_Valeur_Stock.Text = "Valeur :";
            // 
            // label_Fleche_Stock
            // 
            this.label_Fleche_Stock.AutoSize = true;
            this.label_Fleche_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fleche_Stock.Location = new System.Drawing.Point(379, 27);
            this.label_Fleche_Stock.Name = "label_Fleche_Stock";
            this.label_Fleche_Stock.Size = new System.Drawing.Size(25, 20);
            this.label_Fleche_Stock.TabIndex = 20;
            this.label_Fleche_Stock.Text = "→";
            // 
            // label_Champ_Stock
            // 
            this.label_Champ_Stock.AutoSize = true;
            this.label_Champ_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Champ_Stock.Location = new System.Drawing.Point(31, 27);
            this.label_Champ_Stock.Name = "label_Champ_Stock";
            this.label_Champ_Stock.Size = new System.Drawing.Size(136, 20);
            this.label_Champ_Stock.TabIndex = 19;
            this.label_Champ_Stock.Text = "Choix Du Champ :";
            // 
            // groupBox_Trie_Stock
            // 
            this.groupBox_Trie_Stock.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Trie_Stock.Controls.Add(this.comboBox_Trier_Stock);
            this.groupBox_Trie_Stock.Controls.Add(this.label_Trier_Stock);
            this.groupBox_Trie_Stock.Location = new System.Drawing.Point(6, 27);
            this.groupBox_Trie_Stock.Name = "groupBox_Trie_Stock";
            this.groupBox_Trie_Stock.Size = new System.Drawing.Size(323, 62);
            this.groupBox_Trie_Stock.TabIndex = 9;
            this.groupBox_Trie_Stock.TabStop = false;
            this.groupBox_Trie_Stock.Text = "Trie";
            // 
            // comboBox_Trier_Stock
            // 
            this.comboBox_Trier_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Trier_Stock.FormattingEnabled = true;
            this.comboBox_Trier_Stock.Items.AddRange(new object[] {
            "Famille",
            "Réference",
            "Libellé",
            "Fournisseur",
            "PrixU",
            "TVA",
            "Qte",
            "Alerte"});
            this.comboBox_Trier_Stock.Location = new System.Drawing.Point(96, 23);
            this.comboBox_Trier_Stock.Name = "comboBox_Trier_Stock";
            this.comboBox_Trier_Stock.Size = new System.Drawing.Size(211, 28);
            this.comboBox_Trier_Stock.TabIndex = 19;
            this.comboBox_Trier_Stock.SelectedIndexChanged += new System.EventHandler(this.comboBox_Trier_Stock_SelectedIndexChanged_1);
            // 
            // label_Trier_Stock
            // 
            this.label_Trier_Stock.AutoSize = true;
            this.label_Trier_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Trier_Stock.Location = new System.Drawing.Point(10, 27);
            this.label_Trier_Stock.Name = "label_Trier_Stock";
            this.label_Trier_Stock.Size = new System.Drawing.Size(76, 20);
            this.label_Trier_Stock.TabIndex = 18;
            this.label_Trier_Stock.Text = "Trier Par :";
            // 
            // button_Del_Stock
            // 
            this.button_Del_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Del_Stock.Location = new System.Drawing.Point(1127, 257);
            this.button_Del_Stock.Name = "button_Del_Stock";
            this.button_Del_Stock.Size = new System.Drawing.Size(109, 48);
            this.button_Del_Stock.TabIndex = 4;
            this.button_Del_Stock.Text = "Supprimer";
            this.button_Del_Stock.UseVisualStyleBackColor = true;
            this.button_Del_Stock.Click += new System.EventHandler(this.button_Del_Stock_Click);
            // 
            // button_Modif_Stock
            // 
            this.button_Modif_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modif_Stock.Location = new System.Drawing.Point(1127, 203);
            this.button_Modif_Stock.Name = "button_Modif_Stock";
            this.button_Modif_Stock.Size = new System.Drawing.Size(109, 48);
            this.button_Modif_Stock.TabIndex = 3;
            this.button_Modif_Stock.Text = "Modifier";
            this.button_Modif_Stock.UseVisualStyleBackColor = true;
            this.button_Modif_Stock.Click += new System.EventHandler(this.button_Modif_Stock_Click);
            // 
            // button_Alarme_Stock
            // 
            this.button_Alarme_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Alarme_Stock.Location = new System.Drawing.Point(1127, 95);
            this.button_Alarme_Stock.Name = "button_Alarme_Stock";
            this.button_Alarme_Stock.Size = new System.Drawing.Size(109, 48);
            this.button_Alarme_Stock.TabIndex = 2;
            this.button_Alarme_Stock.Text = "Alarme";
            this.button_Alarme_Stock.UseVisualStyleBackColor = true;
            this.button_Alarme_Stock.Click += new System.EventHandler(this.button_Alarme_Stock_Click);
            // 
            // button_Add_Stock
            // 
            this.button_Add_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Stock.Location = new System.Drawing.Point(1127, 149);
            this.button_Add_Stock.Name = "button_Add_Stock";
            this.button_Add_Stock.Size = new System.Drawing.Size(109, 48);
            this.button_Add_Stock.TabIndex = 1;
            this.button_Add_Stock.Text = "Ajouter";
            this.button_Add_Stock.UseVisualStyleBackColor = true;
            this.button_Add_Stock.Click += new System.EventHandler(this.button_Add_Stock_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_del_entree);
            this.tabPage2.Controls.Add(this.dataGridView_entree);
            this.tabPage2.Controls.Add(this.groupBox_filtre_entree);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entrées";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_del_entree
            // 
            this.button_del_entree.Location = new System.Drawing.Point(6, 483);
            this.button_del_entree.Name = "button_del_entree";
            this.button_del_entree.Size = new System.Drawing.Size(109, 41);
            this.button_del_entree.TabIndex = 34;
            this.button_del_entree.Text = "Supprimer";
            this.button_del_entree.UseVisualStyleBackColor = true;
            this.button_del_entree.Click += new System.EventHandler(this.button_del_entree_Click);
            // 
            // dataGridView_entree
            // 
            this.dataGridView_entree.AllowUserToAddRows = false;
            this.dataGridView_entree.AllowUserToDeleteRows = false;
            this.dataGridView_entree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_entree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_entree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit_ent,
            this.qte_ent,
            this.date_ent});
            this.dataGridView_entree.Location = new System.Drawing.Point(5, 98);
            this.dataGridView_entree.Name = "dataGridView_entree";
            this.dataGridView_entree.ReadOnly = true;
            this.dataGridView_entree.Size = new System.Drawing.Size(1235, 382);
            this.dataGridView_entree.TabIndex = 28;
            this.dataGridView_entree.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_entree_CellContentClick);
            // 
            // Produit_ent
            // 
            this.Produit_ent.HeaderText = "Produit";
            this.Produit_ent.Name = "Produit_ent";
            this.Produit_ent.ReadOnly = true;
            // 
            // qte_ent
            // 
            this.qte_ent.HeaderText = "Quantité entrée";
            this.qte_ent.Name = "qte_ent";
            this.qte_ent.ReadOnly = true;
            // 
            // date_ent
            // 
            this.date_ent.HeaderText = "Date Entrée";
            this.date_ent.Name = "date_ent";
            this.date_ent.ReadOnly = true;
            // 
            // groupBox_filtre_entree
            // 
            this.groupBox_filtre_entree.Controls.Add(this.dateTimePicker_fin_entree);
            this.groupBox_filtre_entree.Controls.Add(this.dateTimePicker_debu_entree);
            this.groupBox_filtre_entree.Controls.Add(this.button_ok_entree);
            this.groupBox_filtre_entree.Controls.Add(this.label_valeur_entree);
            this.groupBox_filtre_entree.Controls.Add(this.label_fleche_entree);
            this.groupBox_filtre_entree.Controls.Add(this.label_filtre_champ_entréé);
            this.groupBox_filtre_entree.Location = new System.Drawing.Point(5, 30);
            this.groupBox_filtre_entree.Name = "groupBox_filtre_entree";
            this.groupBox_filtre_entree.Size = new System.Drawing.Size(1115, 62);
            this.groupBox_filtre_entree.TabIndex = 26;
            this.groupBox_filtre_entree.TabStop = false;
            this.groupBox_filtre_entree.Text = "Filtre";
            // 
            // dateTimePicker_fin_entree
            // 
            this.dateTimePicker_fin_entree.Location = new System.Drawing.Point(540, 24);
            this.dateTimePicker_fin_entree.Name = "dateTimePicker_fin_entree";
            this.dateTimePicker_fin_entree.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fin_entree.TabIndex = 26;
            // 
            // dateTimePicker_debu_entree
            // 
            this.dateTimePicker_debu_entree.Location = new System.Drawing.Point(153, 24);
            this.dateTimePicker_debu_entree.Name = "dateTimePicker_debu_entree";
            this.dateTimePicker_debu_entree.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_debu_entree.TabIndex = 25;
            // 
            // button_ok_entree
            // 
            this.button_ok_entree.Location = new System.Drawing.Point(941, 21);
            this.button_ok_entree.Name = "button_ok_entree";
            this.button_ok_entree.Size = new System.Drawing.Size(75, 23);
            this.button_ok_entree.TabIndex = 23;
            this.button_ok_entree.Text = "OK";
            this.button_ok_entree.UseVisualStyleBackColor = true;
            this.button_ok_entree.Click += new System.EventHandler(this.button_ok_entree_Click);
            // 
            // label_valeur_entree
            // 
            this.label_valeur_entree.AutoSize = true;
            this.label_valeur_entree.Location = new System.Drawing.Point(411, 27);
            this.label_valeur_entree.Name = "label_valeur_entree";
            this.label_valeur_entree.Size = new System.Drawing.Size(43, 13);
            this.label_valeur_entree.TabIndex = 21;
            this.label_valeur_entree.Text = "Valeur :";
            // 
            // label_fleche_entree
            // 
            this.label_fleche_entree.AutoSize = true;
            this.label_fleche_entree.Location = new System.Drawing.Point(860, 27);
            this.label_fleche_entree.Name = "label_fleche_entree";
            this.label_fleche_entree.Size = new System.Drawing.Size(18, 13);
            this.label_fleche_entree.TabIndex = 20;
            this.label_fleche_entree.Text = "→";
            // 
            // label_filtre_champ_entréé
            // 
            this.label_filtre_champ_entréé.AutoSize = true;
            this.label_filtre_champ_entréé.Location = new System.Drawing.Point(31, 27);
            this.label_filtre_champ_entréé.Name = "label_filtre_champ_entréé";
            this.label_filtre_champ_entréé.Size = new System.Drawing.Size(92, 13);
            this.label_filtre_champ_entréé.TabIndex = 19;
            this.label_filtre_champ_entréé.Text = "Choix Du Champ :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_filtre_sortie);
            this.tabPage3.Controls.Add(this.button_del_sortie);
            this.tabPage3.Controls.Add(this.dataGridView_sortie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1245, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sorties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_filtre_sortie
            // 
            this.groupBox_filtre_sortie.Controls.Add(this.dateTimePicker_fin_sortie);
            this.groupBox_filtre_sortie.Controls.Add(this.dateTimePicker_debu_sortie);
            this.groupBox_filtre_sortie.Controls.Add(this.button_ok_sortie);
            this.groupBox_filtre_sortie.Controls.Add(this.label_valeur_sortie);
            this.groupBox_filtre_sortie.Controls.Add(this.label_fleche_sortie);
            this.groupBox_filtre_sortie.Controls.Add(this.label_champ_sortie);
            this.groupBox_filtre_sortie.Location = new System.Drawing.Point(6, 30);
            this.groupBox_filtre_sortie.Name = "groupBox_filtre_sortie";
            this.groupBox_filtre_sortie.Size = new System.Drawing.Size(1115, 62);
            this.groupBox_filtre_sortie.TabIndex = 47;
            this.groupBox_filtre_sortie.TabStop = false;
            this.groupBox_filtre_sortie.Text = "Filtre";
            // 
            // dateTimePicker_fin_sortie
            // 
            this.dateTimePicker_fin_sortie.Location = new System.Drawing.Point(540, 24);
            this.dateTimePicker_fin_sortie.Name = "dateTimePicker_fin_sortie";
            this.dateTimePicker_fin_sortie.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fin_sortie.TabIndex = 26;
            // 
            // dateTimePicker_debu_sortie
            // 
            this.dateTimePicker_debu_sortie.Location = new System.Drawing.Point(153, 24);
            this.dateTimePicker_debu_sortie.Name = "dateTimePicker_debu_sortie";
            this.dateTimePicker_debu_sortie.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_debu_sortie.TabIndex = 25;
            // 
            // button_ok_sortie
            // 
            this.button_ok_sortie.Location = new System.Drawing.Point(941, 21);
            this.button_ok_sortie.Name = "button_ok_sortie";
            this.button_ok_sortie.Size = new System.Drawing.Size(75, 23);
            this.button_ok_sortie.TabIndex = 23;
            this.button_ok_sortie.Text = "OK";
            this.button_ok_sortie.UseVisualStyleBackColor = true;
            this.button_ok_sortie.Click += new System.EventHandler(this.button_ok_sortie_Click);
            // 
            // label_valeur_sortie
            // 
            this.label_valeur_sortie.AutoSize = true;
            this.label_valeur_sortie.Location = new System.Drawing.Point(411, 27);
            this.label_valeur_sortie.Name = "label_valeur_sortie";
            this.label_valeur_sortie.Size = new System.Drawing.Size(43, 13);
            this.label_valeur_sortie.TabIndex = 21;
            this.label_valeur_sortie.Text = "Valeur :";
            // 
            // label_fleche_sortie
            // 
            this.label_fleche_sortie.AutoSize = true;
            this.label_fleche_sortie.Location = new System.Drawing.Point(860, 27);
            this.label_fleche_sortie.Name = "label_fleche_sortie";
            this.label_fleche_sortie.Size = new System.Drawing.Size(18, 13);
            this.label_fleche_sortie.TabIndex = 20;
            this.label_fleche_sortie.Text = "→";
            // 
            // label_champ_sortie
            // 
            this.label_champ_sortie.AutoSize = true;
            this.label_champ_sortie.Location = new System.Drawing.Point(31, 27);
            this.label_champ_sortie.Name = "label_champ_sortie";
            this.label_champ_sortie.Size = new System.Drawing.Size(92, 13);
            this.label_champ_sortie.TabIndex = 19;
            this.label_champ_sortie.Text = "Choix Du Champ :";
            // 
            // button_del_sortie
            // 
            this.button_del_sortie.Location = new System.Drawing.Point(6, 483);
            this.button_del_sortie.Name = "button_del_sortie";
            this.button_del_sortie.Size = new System.Drawing.Size(109, 41);
            this.button_del_sortie.TabIndex = 45;
            this.button_del_sortie.Text = "Supprimer";
            this.button_del_sortie.UseVisualStyleBackColor = true;
            this.button_del_sortie.Click += new System.EventHandler(this.button_del_sortie_Click);
            // 
            // dataGridView_sortie
            // 
            this.dataGridView_sortie.AllowUserToAddRows = false;
            this.dataGridView_sortie.AllowUserToDeleteRows = false;
            this.dataGridView_sortie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sortie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_sort,
            this.qte_sort,
            this.date_sort});
            this.dataGridView_sortie.Location = new System.Drawing.Point(5, 98);
            this.dataGridView_sortie.Name = "dataGridView_sortie";
            this.dataGridView_sortie.ReadOnly = true;
            this.dataGridView_sortie.Size = new System.Drawing.Size(1235, 382);
            this.dataGridView_sortie.TabIndex = 39;
            // 
            // prod_sort
            // 
            this.prod_sort.HeaderText = "Produit ";
            this.prod_sort.Name = "prod_sort";
            this.prod_sort.ReadOnly = true;
            // 
            // qte_sort
            // 
            this.qte_sort.HeaderText = "Quantité sortie";
            this.qte_sort.Name = "qte_sort";
            this.qte_sort.ReadOnly = true;
            // 
            // date_sort
            // 
            this.date_sort.HeaderText = "Date Sortie";
            this.date_sort.Name = "date_sort";
            this.date_sort.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label_Fourni);
            this.tabPage4.Controls.Add(this.label_Nb_Fourni);
            this.tabPage4.Controls.Add(this.dataGridView_Fourni);
            this.tabPage4.Controls.Add(this.groupBox_filtre_fourni);
            this.tabPage4.Controls.Add(this.button_Del_All_Fourni);
            this.tabPage4.Controls.Add(this.button_Del_Fourni);
            this.tabPage4.Controls.Add(this.button_Mod_Fourni);
            this.tabPage4.Controls.Add(this.button_Add_Fourni);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1245, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fournisseurs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label_Fourni
            // 
            this.label_Fourni.AutoSize = true;
            this.label_Fourni.Location = new System.Drawing.Point(946, 499);
            this.label_Fourni.Name = "label_Fourni";
            this.label_Fourni.Size = new System.Drawing.Size(85, 13);
            this.label_Fourni.TabIndex = 32;
            this.label_Fourni.Text = "NB.Fourniseurs :";
            // 
            // label_Nb_Fourni
            // 
            this.label_Nb_Fourni.AutoSize = true;
            this.label_Nb_Fourni.Location = new System.Drawing.Point(1028, 499);
            this.label_Nb_Fourni.Name = "label_Nb_Fourni";
            this.label_Nb_Fourni.Size = new System.Drawing.Size(35, 13);
            this.label_Nb_Fourni.TabIndex = 29;
            this.label_Nb_Fourni.Text = "label1";
            // 
            // dataGridView_Fourni
            // 
            this.dataGridView_Fourni.AllowUserToAddRows = false;
            this.dataGridView_Fourni.AllowUserToDeleteRows = false;
            this.dataGridView_Fourni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Fourni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Fourni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fourni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Num,
            this.Rue,
            this.Ville,
            this.Cp,
            this.Mail,
            this.Tel});
            this.dataGridView_Fourni.Location = new System.Drawing.Point(6, 95);
            this.dataGridView_Fourni.Name = "dataGridView_Fourni";
            this.dataGridView_Fourni.ReadOnly = true;
            this.dataGridView_Fourni.Size = new System.Drawing.Size(1057, 382);
            this.dataGridView_Fourni.TabIndex = 28;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.HeaderText = "N°";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // Cp
            // 
            this.Cp.HeaderText = "Code Postal";
            this.Cp.Name = "Cp";
            this.Cp.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Telephone";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // groupBox_filtre_fourni
            // 
            this.groupBox_filtre_fourni.Controls.Add(this.textBox_Valeur_Fourni);
            this.groupBox_filtre_fourni.Controls.Add(this.comboBox_Champ_Fourni);
            this.groupBox_filtre_fourni.Controls.Add(this.label_Valeur_Fourni);
            this.groupBox_filtre_fourni.Controls.Add(this.label_Fleche_Fourni);
            this.groupBox_filtre_fourni.Controls.Add(this.label_champ_Fourni);
            this.groupBox_filtre_fourni.Location = new System.Drawing.Point(6, 27);
            this.groupBox_filtre_fourni.Name = "groupBox_filtre_fourni";
            this.groupBox_filtre_fourni.Size = new System.Drawing.Size(817, 62);
            this.groupBox_filtre_fourni.TabIndex = 26;
            this.groupBox_filtre_fourni.TabStop = false;
            this.groupBox_filtre_fourni.Text = "Filtre";
            // 
            // textBox_Valeur_Fourni
            // 
            this.textBox_Valeur_Fourni.Location = new System.Drawing.Point(496, 23);
            this.textBox_Valeur_Fourni.Name = "textBox_Valeur_Fourni";
            this.textBox_Valeur_Fourni.Size = new System.Drawing.Size(275, 20);
            this.textBox_Valeur_Fourni.TabIndex = 24;
            this.textBox_Valeur_Fourni.TextChanged += new System.EventHandler(this.textBox_Valeur_Fourni_TextChanged);
            // 
            // comboBox_Champ_Fourni
            // 
            this.comboBox_Champ_Fourni.FormattingEnabled = true;
            this.comboBox_Champ_Fourni.Items.AddRange(new object[] {
            "nom",
            "n°",
            "rue",
            "ville",
            "code postal",
            "mail",
            "telephone"});
            this.comboBox_Champ_Fourni.Location = new System.Drawing.Point(147, 23);
            this.comboBox_Champ_Fourni.Name = "comboBox_Champ_Fourni";
            this.comboBox_Champ_Fourni.Size = new System.Drawing.Size(184, 21);
            this.comboBox_Champ_Fourni.TabIndex = 22;
            // 
            // label_Valeur_Fourni
            // 
            this.label_Valeur_Fourni.AutoSize = true;
            this.label_Valeur_Fourni.Location = new System.Drawing.Point(411, 27);
            this.label_Valeur_Fourni.Name = "label_Valeur_Fourni";
            this.label_Valeur_Fourni.Size = new System.Drawing.Size(43, 13);
            this.label_Valeur_Fourni.TabIndex = 21;
            this.label_Valeur_Fourni.Text = "Valeur :";
            // 
            // label_Fleche_Fourni
            // 
            this.label_Fleche_Fourni.AutoSize = true;
            this.label_Fleche_Fourni.Location = new System.Drawing.Point(358, 27);
            this.label_Fleche_Fourni.Name = "label_Fleche_Fourni";
            this.label_Fleche_Fourni.Size = new System.Drawing.Size(18, 13);
            this.label_Fleche_Fourni.TabIndex = 20;
            this.label_Fleche_Fourni.Text = "→";
            // 
            // label_champ_Fourni
            // 
            this.label_champ_Fourni.AutoSize = true;
            this.label_champ_Fourni.Location = new System.Drawing.Point(31, 27);
            this.label_champ_Fourni.Name = "label_champ_Fourni";
            this.label_champ_Fourni.Size = new System.Drawing.Size(92, 13);
            this.label_champ_Fourni.TabIndex = 19;
            this.label_champ_Fourni.Text = "Choix Du Champ :";
            // 
            // button_Del_All_Fourni
            // 
            this.button_Del_All_Fourni.Location = new System.Drawing.Point(6, 483);
            this.button_Del_All_Fourni.Name = "button_Del_All_Fourni";
            this.button_Del_All_Fourni.Size = new System.Drawing.Size(147, 41);
            this.button_Del_All_Fourni.TabIndex = 23;
            this.button_Del_All_Fourni.Text = "Supprimer Tout";
            this.button_Del_All_Fourni.UseVisualStyleBackColor = true;
            // 
            // button_Del_Fourni
            // 
            this.button_Del_Fourni.Location = new System.Drawing.Point(1069, 350);
            this.button_Del_Fourni.Name = "button_Del_Fourni";
            this.button_Del_Fourni.Size = new System.Drawing.Size(167, 107);
            this.button_Del_Fourni.TabIndex = 22;
            this.button_Del_Fourni.Text = "Supprimer";
            this.button_Del_Fourni.UseVisualStyleBackColor = true;
            this.button_Del_Fourni.Click += new System.EventHandler(this.button_Del_Fourni_Click);
            // 
            // button_Mod_Fourni
            // 
            this.button_Mod_Fourni.Location = new System.Drawing.Point(1069, 237);
            this.button_Mod_Fourni.Name = "button_Mod_Fourni";
            this.button_Mod_Fourni.Size = new System.Drawing.Size(167, 107);
            this.button_Mod_Fourni.TabIndex = 21;
            this.button_Mod_Fourni.Text = "Modifier";
            this.button_Mod_Fourni.UseVisualStyleBackColor = true;
            this.button_Mod_Fourni.Click += new System.EventHandler(this.button_Mod_Fourni_Click);
            // 
            // button_Add_Fourni
            // 
            this.button_Add_Fourni.Location = new System.Drawing.Point(1069, 124);
            this.button_Add_Fourni.Name = "button_Add_Fourni";
            this.button_Add_Fourni.Size = new System.Drawing.Size(167, 107);
            this.button_Add_Fourni.TabIndex = 19;
            this.button_Add_Fourni.Text = "Ajouter";
            this.button_Add_Fourni.UseVisualStyleBackColor = true;
            this.button_Add_Fourni.Click += new System.EventHandler(this.button_Add_Fourni_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label_nb_tva);
            this.tabPage5.Controls.Add(this.label_tva);
            this.tabPage5.Controls.Add(this.dataGridView_tva);
            this.tabPage5.Controls.Add(this.button_del_tva);
            this.tabPage5.Controls.Add(this.button_mod_tva);
            this.tabPage5.Controls.Add(this.button_add_tva);
            this.tabPage5.Controls.Add(this.label_nbf_famille);
            this.tabPage5.Controls.Add(this.label_nb_famille);
            this.tabPage5.Controls.Add(this.dataGridView_famille);
            this.tabPage5.Controls.Add(this.button_del_famille);
            this.tabPage5.Controls.Add(this.button_modifier_famille);
            this.tabPage5.Controls.Add(this.button_add_famille);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1245, 530);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tva / Familles";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 31);
            this.label4.TabIndex = 52;
            this.label4.Text = "Familles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 51;
            this.label3.Text = "TVA";
            // 
            // label_nb_tva
            // 
            this.label_nb_tva.AutoSize = true;
            this.label_nb_tva.Location = new System.Drawing.Point(316, 497);
            this.label_nb_tva.Name = "label_nb_tva";
            this.label_nb_tva.Size = new System.Drawing.Size(50, 13);
            this.label_nb_tva.TabIndex = 50;
            this.label_nb_tva.Text = "NB.Tva :";
            // 
            // label_tva
            // 
            this.label_tva.AutoSize = true;
            this.label_tva.Location = new System.Drawing.Point(373, 498);
            this.label_tva.Name = "label_tva";
            this.label_tva.Size = new System.Drawing.Size(35, 13);
            this.label_tva.TabIndex = 49;
            this.label_tva.Text = "label1";
            // 
            // dataGridView_tva
            // 
            this.dataGridView_tva.AllowUserToAddRows = false;
            this.dataGridView_tva.AllowUserToDeleteRows = false;
            this.dataGridView_tva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_tva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Tva,
            this.Tva});
            this.dataGridView_tva.Location = new System.Drawing.Point(6, 67);
            this.dataGridView_tva.Name = "dataGridView_tva";
            this.dataGridView_tva.ReadOnly = true;
            this.dataGridView_tva.Size = new System.Drawing.Size(427, 410);
            this.dataGridView_tva.TabIndex = 48;
            this.dataGridView_tva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tva_CellContentClick);
            // 
            // Id_Tva
            // 
            this.Id_Tva.HeaderText = "Id_Tva";
            this.Id_Tva.Name = "Id_Tva";
            this.Id_Tva.ReadOnly = true;
            // 
            // Tva
            // 
            this.Tva.HeaderText = "Tva";
            this.Tva.Name = "Tva";
            this.Tva.ReadOnly = true;
            // 
            // button_del_tva
            // 
            this.button_del_tva.Location = new System.Drawing.Point(439, 372);
            this.button_del_tva.Name = "button_del_tva";
            this.button_del_tva.Size = new System.Drawing.Size(167, 107);
            this.button_del_tva.TabIndex = 45;
            this.button_del_tva.Text = "Supprimer";
            this.button_del_tva.UseVisualStyleBackColor = true;
            this.button_del_tva.Click += new System.EventHandler(this.button_del_tva_Click);
            // 
            // button_mod_tva
            // 
            this.button_mod_tva.Location = new System.Drawing.Point(439, 215);
            this.button_mod_tva.Name = "button_mod_tva";
            this.button_mod_tva.Size = new System.Drawing.Size(167, 107);
            this.button_mod_tva.TabIndex = 44;
            this.button_mod_tva.Text = "Modifier";
            this.button_mod_tva.UseVisualStyleBackColor = true;
            this.button_mod_tva.Click += new System.EventHandler(this.button_mod_tva_Click);
            // 
            // button_add_tva
            // 
            this.button_add_tva.Location = new System.Drawing.Point(439, 67);
            this.button_add_tva.Name = "button_add_tva";
            this.button_add_tva.Size = new System.Drawing.Size(167, 107);
            this.button_add_tva.TabIndex = 43;
            this.button_add_tva.Text = "Ajouter";
            this.button_add_tva.UseVisualStyleBackColor = true;
            this.button_add_tva.Click += new System.EventHandler(this.button_add_tva_Click);
            // 
            // label_nbf_famille
            // 
            this.label_nbf_famille.AutoSize = true;
            this.label_nbf_famille.Location = new System.Drawing.Point(947, 497);
            this.label_nbf_famille.Name = "label_nbf_famille";
            this.label_nbf_famille.Size = new System.Drawing.Size(63, 13);
            this.label_nbf_famille.TabIndex = 42;
            this.label_nbf_famille.Text = "NB.Famille :";
            // 
            // label_nb_famille
            // 
            this.label_nb_famille.AutoSize = true;
            this.label_nb_famille.Location = new System.Drawing.Point(1016, 497);
            this.label_nb_famille.Name = "label_nb_famille";
            this.label_nb_famille.Size = new System.Drawing.Size(35, 13);
            this.label_nb_famille.TabIndex = 41;
            this.label_nb_famille.Text = "label1";
            // 
            // dataGridView_famille
            // 
            this.dataGridView_famille.AllowUserToAddRows = false;
            this.dataGridView_famille.AllowUserToDeleteRows = false;
            this.dataGridView_famille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_famille.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_famille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_famille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_Famille,
            this.Description});
            this.dataGridView_famille.Location = new System.Drawing.Point(637, 67);
            this.dataGridView_famille.Name = "dataGridView_famille";
            this.dataGridView_famille.ReadOnly = true;
            this.dataGridView_famille.Size = new System.Drawing.Size(427, 410);
            this.dataGridView_famille.TabIndex = 40;
            // 
            // Nom_Famille
            // 
            this.Nom_Famille.HeaderText = "Nom_Famille";
            this.Nom_Famille.Name = "Nom_Famille";
            this.Nom_Famille.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // button_del_famille
            // 
            this.button_del_famille.Location = new System.Drawing.Point(1072, 371);
            this.button_del_famille.Name = "button_del_famille";
            this.button_del_famille.Size = new System.Drawing.Size(167, 107);
            this.button_del_famille.TabIndex = 36;
            this.button_del_famille.Text = "Supprimer";
            this.button_del_famille.UseVisualStyleBackColor = true;
            this.button_del_famille.Click += new System.EventHandler(this.button_del_famille_Click);
            // 
            // button_modifier_famille
            // 
            this.button_modifier_famille.Location = new System.Drawing.Point(1072, 215);
            this.button_modifier_famille.Name = "button_modifier_famille";
            this.button_modifier_famille.Size = new System.Drawing.Size(167, 107);
            this.button_modifier_famille.TabIndex = 35;
            this.button_modifier_famille.Text = "Modifier";
            this.button_modifier_famille.UseVisualStyleBackColor = true;
            this.button_modifier_famille.Click += new System.EventHandler(this.button_modifier_famille_Click);
            // 
            // button_add_famille
            // 
            this.button_add_famille.Location = new System.Drawing.Point(1072, 67);
            this.button_add_famille.Name = "button_add_famille";
            this.button_add_famille.Size = new System.Drawing.Size(167, 107);
            this.button_add_famille.TabIndex = 34;
            this.button_add_famille.Text = "Ajouter";
            this.button_add_famille.UseVisualStyleBackColor = true;
            this.button_add_famille.Click += new System.EventHandler(this.button_add_famille_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestionnaire de Stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).EndInit();
            this.groupBox_Enter_Sortie.ResumeLayout(false);
            this.groupBox_Filtre_Stock.ResumeLayout(false);
            this.groupBox_Filtre_Stock.PerformLayout();
            this.groupBox_Trie_Stock.ResumeLayout(false);
            this.groupBox_Trie_Stock.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_entree)).EndInit();
            this.groupBox_filtre_entree.ResumeLayout(false);
            this.groupBox_filtre_entree.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox_filtre_sortie.ResumeLayout(false);
            this.groupBox_filtre_sortie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sortie)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fourni)).EndInit();
            this.groupBox_filtre_fourni.ResumeLayout(false);
            this.groupBox_filtre_fourni.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_famille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_Sortie_Stock;
        private System.Windows.Forms.Button button_Entree_Stock;
        private System.Windows.Forms.Button button_Add_Stock;
        private System.Windows.Forms.Button button_Alarme_Stock;
        private System.Windows.Forms.Button button_Modif_Stock;
        private System.Windows.Forms.Button button_Del_Stock;
        private System.Windows.Forms.GroupBox groupBox_Enter_Sortie;
        private System.Windows.Forms.GroupBox groupBox_Filtre_Stock;
        private System.Windows.Forms.GroupBox groupBox_Trie_Stock;
        private System.Windows.Forms.Label label_Montant_Capital_Stock;
        private System.Windows.Forms.Label label_Art_Stock;
        private System.Windows.Forms.Label label_Capital_Stock;
        private System.Windows.Forms.Label label_Nb_Art_Stock;
        private System.Windows.Forms.Label label_Valeur_Stock;
        private System.Windows.Forms.Label label_Fleche_Stock;
        private System.Windows.Forms.Label label_Champ_Stock;
        private System.Windows.Forms.Label label_Trier_Stock;
        private System.Windows.Forms.ComboBox comboBox_Trier_Stock;
        private System.Windows.Forms.TextBox textBox_Valeur_Stock;
        private System.Windows.Forms.Button button_Mult_Stock;
        private System.Windows.Forms.ComboBox comboBox_Champ_Stock;
        private System.Windows.Forms.Label label_Fourni;
        private System.Windows.Forms.Label label_Nb_Fourni;
        private System.Windows.Forms.DataGridView dataGridView_Fourni;
        private System.Windows.Forms.GroupBox groupBox_filtre_fourni;
        private System.Windows.Forms.TextBox textBox_Valeur_Fourni;
        private System.Windows.Forms.ComboBox comboBox_Champ_Fourni;
        private System.Windows.Forms.Label label_Valeur_Fourni;
        private System.Windows.Forms.Label label_Fleche_Fourni;
        private System.Windows.Forms.Label label_champ_Fourni;
        private System.Windows.Forms.Button button_Del_All_Fourni;
        private System.Windows.Forms.Button button_Del_Fourni;
        private System.Windows.Forms.Button button_Mod_Fourni;
        private System.Windows.Forms.Button button_Add_Fourni;
        private System.Windows.Forms.DataGridView dataGridView_entree;
        private System.Windows.Forms.GroupBox groupBox_filtre_entree;
        private System.Windows.Forms.Button button_ok_entree;
        private System.Windows.Forms.Label label_valeur_entree;
        private System.Windows.Forms.Label label_fleche_entree;
        private System.Windows.Forms.Label label_filtre_champ_entréé;
        private System.Windows.Forms.Button button_del_sortie;
        private System.Windows.Forms.DataGridView dataGridView_sortie;
        private System.Windows.Forms.Label label_nbf_famille;
        private System.Windows.Forms.Label label_nb_famille;
        private System.Windows.Forms.DataGridView dataGridView_famille;
        private System.Windows.Forms.Button button_del_famille;
        private System.Windows.Forms.Button button_modifier_famille;
        private System.Windows.Forms.Button button_add_famille;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin_entree;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debu_entree;
        private System.Windows.Forms.GroupBox groupBox_filtre_sortie;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin_sortie;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debu_sortie;
        private System.Windows.Forms.Button button_ok_sortie;
        private System.Windows.Forms.Label label_valeur_sortie;
        private System.Windows.Forms.Label label_fleche_sortie;
        private System.Windows.Forms.Label label_champ_sortie;
        public System.Windows.Forms.DataGridView dataGridView_Stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_nb_tva;
        private System.Windows.Forms.Label label_tva;
        private System.Windows.Forms.DataGridView dataGridView_tva;
        private System.Windows.Forms.Button button_del_tva;
        private System.Windows.Forms.Button button_mod_tva;
        private System.Windows.Forms.Button button_add_tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnetva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte_alrt_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fourni_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libel_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_del_entree;
    }
}

