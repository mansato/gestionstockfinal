namespace Gestion_Stock
{
    partial class Form_Art
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_Fam_art = new System.Windows.Forms.Label();
            this.label_Ref_Art = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_four_art = new System.Windows.Forms.Label();
            this.label_prixu_art = new System.Windows.Forms.Label();
            this.label_quant_art = new System.Windows.Forms.Label();
            this.comboBox_fam_art = new System.Windows.Forms.ComboBox();
            this.comboBox_four_art = new System.Windows.Forms.ComboBox();
            this.textBox_ref = new System.Windows.Forms.TextBox();
            this.textBox_design = new System.Windows.Forms.TextBox();
            this.textBox_prixu = new System.Windows.Forms.TextBox();
            this.textBox_qte = new System.Windows.Forms.TextBox();
            this.textBox_qta = new System.Windows.Forms.TextBox();
            this.button_enreg_art = new System.Windows.Forms.Button();
            this.button_annu_art = new System.Windows.Forms.Button();
            this.label_quant_min_art = new System.Windows.Forms.Label();
            this.comboBox_Tva = new System.Windows.Forms.ComboBox();
            this.label_Tva = new System.Windows.Forms.Label();
            this.button_enregistre_mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer un nouvel article";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Fam_art
            // 
            this.label_Fam_art.AutoSize = true;
            this.label_Fam_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fam_art.Location = new System.Drawing.Point(45, 65);
            this.label_Fam_art.Name = "label_Fam_art";
            this.label_Fam_art.Size = new System.Drawing.Size(67, 20);
            this.label_Fam_art.TabIndex = 1;
            this.label_Fam_art.Text = "Famille :";
            // 
            // label_Ref_Art
            // 
            this.label_Ref_Art.AutoSize = true;
            this.label_Ref_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ref_Art.Location = new System.Drawing.Point(12, 100);
            this.label_Ref_Art.Name = "label_Ref_Art";
            this.label_Ref_Art.Size = new System.Drawing.Size(100, 20);
            this.label_Ref_Art.TabIndex = 2;
            this.label_Ref_Art.Text = "Références :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Désignation :";
            // 
            // label_four_art
            // 
            this.label_four_art.AutoSize = true;
            this.label_four_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_four_art.Location = new System.Drawing.Point(11, 166);
            this.label_four_art.Name = "label_four_art";
            this.label_four_art.Size = new System.Drawing.Size(101, 20);
            this.label_four_art.TabIndex = 5;
            this.label_four_art.Text = "Fournisseur :";
            // 
            // label_prixu_art
            // 
            this.label_prixu_art.AutoSize = true;
            this.label_prixu_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prixu_art.Location = new System.Drawing.Point(14, 204);
            this.label_prixu_art.Name = "label_prixu_art";
            this.label_prixu_art.Size = new System.Drawing.Size(98, 20);
            this.label_prixu_art.TabIndex = 6;
            this.label_prixu_art.Text = "Prix unitaire :";
            // 
            // label_quant_art
            // 
            this.label_quant_art.AutoSize = true;
            this.label_quant_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quant_art.Location = new System.Drawing.Point(34, 237);
            this.label_quant_art.Name = "label_quant_art";
            this.label_quant_art.Size = new System.Drawing.Size(78, 20);
            this.label_quant_art.TabIndex = 8;
            this.label_quant_art.Text = "Quantité :";
            // 
            // comboBox_fam_art
            // 
            this.comboBox_fam_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_fam_art.FormattingEnabled = true;
            this.comboBox_fam_art.Location = new System.Drawing.Point(122, 66);
            this.comboBox_fam_art.Name = "comboBox_fam_art";
            this.comboBox_fam_art.Size = new System.Drawing.Size(178, 24);
            this.comboBox_fam_art.TabIndex = 9;
            // 
            // comboBox_four_art
            // 
            this.comboBox_four_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_four_art.FormattingEnabled = true;
            this.comboBox_four_art.Location = new System.Drawing.Point(122, 170);
            this.comboBox_four_art.Name = "comboBox_four_art";
            this.comboBox_four_art.Size = new System.Drawing.Size(178, 24);
            this.comboBox_four_art.TabIndex = 11;
            // 
            // textBox_ref
            // 
            this.textBox_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ref.Location = new System.Drawing.Point(122, 101);
            this.textBox_ref.Name = "textBox_ref";
            this.textBox_ref.Size = new System.Drawing.Size(178, 22);
            this.textBox_ref.TabIndex = 12;
            // 
            // textBox_design
            // 
            this.textBox_design.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_design.Location = new System.Drawing.Point(122, 136);
            this.textBox_design.Name = "textBox_design";
            this.textBox_design.Size = new System.Drawing.Size(178, 22);
            this.textBox_design.TabIndex = 13;
            // 
            // textBox_prixu
            // 
            this.textBox_prixu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prixu.Location = new System.Drawing.Point(122, 205);
            this.textBox_prixu.Name = "textBox_prixu";
            this.textBox_prixu.Size = new System.Drawing.Size(178, 22);
            this.textBox_prixu.TabIndex = 14;
            // 
            // textBox_qte
            // 
            this.textBox_qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_qte.Location = new System.Drawing.Point(122, 238);
            this.textBox_qte.Name = "textBox_qte";
            this.textBox_qte.Size = new System.Drawing.Size(178, 22);
            this.textBox_qte.TabIndex = 15;
            // 
            // textBox_qta
            // 
            this.textBox_qta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_qta.Location = new System.Drawing.Point(122, 273);
            this.textBox_qta.Name = "textBox_qta";
            this.textBox_qta.Size = new System.Drawing.Size(178, 22);
            this.textBox_qta.TabIndex = 16;
            // 
            // button_enreg_art
            // 
            this.button_enreg_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enreg_art.Location = new System.Drawing.Point(21, 368);
            this.button_enreg_art.Name = "button_enreg_art";
            this.button_enreg_art.Size = new System.Drawing.Size(120, 35);
            this.button_enreg_art.TabIndex = 17;
            this.button_enreg_art.Text = "Enregistrer";
            this.button_enreg_art.UseVisualStyleBackColor = true;
            this.button_enreg_art.Click += new System.EventHandler(this.button_enreg_art_Click);
            // 
            // button_annu_art
            // 
            this.button_annu_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annu_art.Location = new System.Drawing.Point(185, 368);
            this.button_annu_art.Name = "button_annu_art";
            this.button_annu_art.Size = new System.Drawing.Size(120, 35);
            this.button_annu_art.TabIndex = 18;
            this.button_annu_art.Text = "Annuler";
            this.button_annu_art.UseVisualStyleBackColor = true;
            // 
            // label_quant_min_art
            // 
            this.label_quant_min_art.AutoSize = true;
            this.label_quant_min_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quant_min_art.Location = new System.Drawing.Point(5, 272);
            this.label_quant_min_art.Name = "label_quant_min_art";
            this.label_quant_min_art.Size = new System.Drawing.Size(107, 20);
            this.label_quant_min_art.TabIndex = 19;
            this.label_quant_min_art.Text = "Quantité min :";
            // 
            // comboBox_Tva
            // 
            this.comboBox_Tva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Tva.FormattingEnabled = true;
            this.comboBox_Tva.Location = new System.Drawing.Point(122, 308);
            this.comboBox_Tva.Name = "comboBox_Tva";
            this.comboBox_Tva.Size = new System.Drawing.Size(178, 24);
            this.comboBox_Tva.TabIndex = 20;
            // 
            // label_Tva
            // 
            this.label_Tva.AutoSize = true;
            this.label_Tva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tva.Location = new System.Drawing.Point(70, 307);
            this.label_Tva.Name = "label_Tva";
            this.label_Tva.Size = new System.Drawing.Size(42, 20);
            this.label_Tva.TabIndex = 21;
            this.label_Tva.Text = "Tva :";
            // 
            // button_enregistre_mod
            // 
            this.button_enregistre_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enregistre_mod.Location = new System.Drawing.Point(112, 368);
            this.button_enregistre_mod.Name = "button_enregistre_mod";
            this.button_enregistre_mod.Size = new System.Drawing.Size(120, 35);
            this.button_enregistre_mod.TabIndex = 22;
            this.button_enregistre_mod.Text = "Enregistrer";
            this.button_enregistre_mod.UseVisualStyleBackColor = true;
            this.button_enregistre_mod.Visible = false;
            this.button_enregistre_mod.Click += new System.EventHandler(this.button_enregistre_mod_Click);
            // 
            // Form_Art
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 415);
            this.Controls.Add(this.button_enregistre_mod);
            this.Controls.Add(this.label_Tva);
            this.Controls.Add(this.comboBox_Tva);
            this.Controls.Add(this.label_quant_min_art);
            this.Controls.Add(this.button_annu_art);
            this.Controls.Add(this.button_enreg_art);
            this.Controls.Add(this.textBox_qta);
            this.Controls.Add(this.textBox_qte);
            this.Controls.Add(this.textBox_prixu);
            this.Controls.Add(this.textBox_design);
            this.Controls.Add(this.textBox_ref);
            this.Controls.Add(this.comboBox_four_art);
            this.Controls.Add(this.comboBox_fam_art);
            this.Controls.Add(this.label_quant_art);
            this.Controls.Add(this.label_prixu_art);
            this.Controls.Add(this.label_four_art);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Ref_Art);
            this.Controls.Add(this.label_Fam_art);
            this.Controls.Add(this.label1);
            this.Name = "Form_Art";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Art";
            this.Load += new System.EventHandler(this.Form_Art_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Fam_art;
        private System.Windows.Forms.Label label_Ref_Art;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_four_art;
        private System.Windows.Forms.Label label_prixu_art;
        private System.Windows.Forms.Label label_quant_art;
        private System.Windows.Forms.Label label_quant_min_art;
        private System.Windows.Forms.Label label_Tva;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_fam_art;
        public System.Windows.Forms.ComboBox comboBox_four_art;
        public System.Windows.Forms.TextBox textBox_ref;
        public System.Windows.Forms.TextBox textBox_design;
        public System.Windows.Forms.TextBox textBox_prixu;
        public System.Windows.Forms.TextBox textBox_qte;
        public System.Windows.Forms.TextBox textBox_qta;
        public System.Windows.Forms.Button button_enreg_art;
        public System.Windows.Forms.Button button_annu_art;
        public System.Windows.Forms.ComboBox comboBox_Tva;
        public System.Windows.Forms.Button button_enregistre_mod;
    }
}