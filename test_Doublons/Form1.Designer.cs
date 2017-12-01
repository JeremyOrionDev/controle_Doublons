namespace test_Doublons
{
    partial class formRechercheDoublons
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
            this.btnFichier = new System.Windows.Forms.Button();
            this.tBxAdress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblColonnes = new System.Windows.Forms.Label();
            this.tBxColonnes = new System.Windows.Forms.TextBox();
            this.lblLignes = new System.Windows.Forms.Label();
            this.tBxLigne = new System.Windows.Forms.TextBox();
            this.lblChoixSeparateur = new System.Windows.Forms.Label();
            this.comboSeparateur = new System.Windows.Forms.ComboBox();
            this.flowComplet = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowSeparateur = new System.Windows.Forms.FlowLayoutPanel();
            this.flowColonnes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLigne = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRecherche = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtLigne = new System.Windows.Forms.RadioButton();
            this.rbtColonne = new System.Windows.Forms.RadioButton();
            this.comboColonne = new System.Windows.Forms.ComboBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.flowComplet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowSeparateur.SuspendLayout();
            this.flowColonnes.SuspendLayout();
            this.flowLigne.SuspendLayout();
            this.flowRecherche.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFichier
            // 
            this.btnFichier.Location = new System.Drawing.Point(3, 3);
            this.btnFichier.Margin = new System.Windows.Forms.Padding(3, 3, 70, 3);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(80, 23);
            this.btnFichier.TabIndex = 0;
            this.btnFichier.Text = "&Fichier";
            this.btnFichier.UseVisualStyleBackColor = true;
            this.btnFichier.Click += new System.EventHandler(this.btnFichier_Click);
            // 
            // tBxAdress
            // 
            this.tBxAdress.Location = new System.Drawing.Point(95, 6);
            this.tBxAdress.Name = "tBxAdress";
            this.tBxAdress.ReadOnly = true;
            this.tBxAdress.Size = new System.Drawing.Size(260, 20);
            this.tBxAdress.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblColonnes
            // 
            this.lblColonnes.Location = new System.Drawing.Point(3, 9);
            this.lblColonnes.Margin = new System.Windows.Forms.Padding(3, 6, 90, 0);
            this.lblColonnes.Name = "lblColonnes";
            this.lblColonnes.Size = new System.Drawing.Size(60, 13);
            this.lblColonnes.TabIndex = 2;
            this.lblColonnes.Text = "Colonnes";
            // 
            // tBxColonnes
            // 
            this.tBxColonnes.Location = new System.Drawing.Point(156, 6);
            this.tBxColonnes.Name = "tBxColonnes";
            this.tBxColonnes.ReadOnly = true;
            this.tBxColonnes.Size = new System.Drawing.Size(260, 20);
            this.tBxColonnes.TabIndex = 3;
            // 
            // lblLignes
            // 
            this.lblLignes.Location = new System.Drawing.Point(3, 10);
            this.lblLignes.Margin = new System.Windows.Forms.Padding(3, 10, 100, 0);
            this.lblLignes.Name = "lblLignes";
            this.lblLignes.Size = new System.Drawing.Size(50, 13);
            this.lblLignes.TabIndex = 2;
            this.lblLignes.Text = "Lignes";
            // 
            // tBxLigne
            // 
            this.tBxLigne.Location = new System.Drawing.Point(156, 3);
            this.tBxLigne.Name = "tBxLigne";
            this.tBxLigne.ReadOnly = true;
            this.tBxLigne.Size = new System.Drawing.Size(260, 20);
            this.tBxLigne.TabIndex = 3;
            // 
            // lblChoixSeparateur
            // 
            this.lblChoixSeparateur.Location = new System.Drawing.Point(3, 5);
            this.lblChoixSeparateur.Margin = new System.Windows.Forms.Padding(3, 5, 20, 0);
            this.lblChoixSeparateur.Name = "lblChoixSeparateur";
            this.lblChoixSeparateur.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblChoixSeparateur.Size = new System.Drawing.Size(130, 24);
            this.lblChoixSeparateur.TabIndex = 4;
            this.lblChoixSeparateur.Text = "Sélectionner séparateur:";
            // 
            // comboSeparateur
            // 
            this.comboSeparateur.FormattingEnabled = true;
            this.comboSeparateur.Location = new System.Drawing.Point(156, 3);
            this.comboSeparateur.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.comboSeparateur.Name = "comboSeparateur";
            this.comboSeparateur.Size = new System.Drawing.Size(49, 21);
            this.comboSeparateur.TabIndex = 5;
            // 
            // flowComplet
            // 
            this.flowComplet.AutoSize = true;
            this.flowComplet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowComplet.Controls.Add(this.panel1);
            this.flowComplet.Controls.Add(this.flowSeparateur);
            this.flowComplet.Controls.Add(this.flowColonnes);
            this.flowComplet.Controls.Add(this.flowLigne);
            this.flowComplet.Controls.Add(this.flowRecherche);
            this.flowComplet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowComplet.Location = new System.Drawing.Point(12, 12);
            this.flowComplet.MaximumSize = new System.Drawing.Size(442, 206);
            this.flowComplet.MinimumSize = new System.Drawing.Size(440, 40);
            this.flowComplet.Name = "flowComplet";
            this.flowComplet.Size = new System.Drawing.Size(440, 189);
            this.flowComplet.TabIndex = 6;
            this.flowComplet.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFichier);
            this.panel1.Controls.Add(this.tBxAdress);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 30);
            this.panel1.TabIndex = 11;
            // 
            // flowSeparateur
            // 
            this.flowSeparateur.AutoSize = true;
            this.flowSeparateur.Controls.Add(this.lblChoixSeparateur);
            this.flowSeparateur.Controls.Add(this.comboSeparateur);
            this.flowSeparateur.Location = new System.Drawing.Point(3, 39);
            this.flowSeparateur.Name = "flowSeparateur";
            this.flowSeparateur.Size = new System.Drawing.Size(355, 29);
            this.flowSeparateur.TabIndex = 10;
            this.flowSeparateur.Visible = false;
            // 
            // flowColonnes
            // 
            this.flowColonnes.AutoSize = true;
            this.flowColonnes.Controls.Add(this.lblColonnes);
            this.flowColonnes.Controls.Add(this.tBxColonnes);
            this.flowColonnes.Location = new System.Drawing.Point(3, 74);
            this.flowColonnes.Name = "flowColonnes";
            this.flowColonnes.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowColonnes.Size = new System.Drawing.Size(419, 29);
            this.flowColonnes.TabIndex = 7;
            this.flowColonnes.Visible = false;
            // 
            // flowLigne
            // 
            this.flowLigne.AutoSize = true;
            this.flowLigne.Controls.Add(this.lblLignes);
            this.flowLigne.Controls.Add(this.tBxLigne);
            this.flowLigne.Location = new System.Drawing.Point(3, 109);
            this.flowLigne.Name = "flowLigne";
            this.flowLigne.Size = new System.Drawing.Size(419, 26);
            this.flowLigne.TabIndex = 8;
            this.flowLigne.Visible = false;
            // 
            // flowRecherche
            // 
            this.flowRecherche.AutoSize = true;
            this.flowRecherche.Controls.Add(this.lblSel);
            this.flowRecherche.Controls.Add(this.flowLayoutPanel2);
            this.flowRecherche.Location = new System.Drawing.Point(3, 141);
            this.flowRecherche.Name = "flowRecherche";
            this.flowRecherche.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.flowRecherche.Size = new System.Drawing.Size(419, 45);
            this.flowRecherche.TabIndex = 12;
            this.flowRecherche.Visible = false;
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.Location = new System.Drawing.Point(8, 17);
            this.lblSel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblSel.Name = "lblSel";
            this.lblSel.Size = new System.Drawing.Size(78, 13);
            this.lblSel.TabIndex = 0;
            this.lblSel.Text = "recherche sur :";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbtLigne);
            this.flowLayoutPanel2.Controls.Add(this.rbtColonne);
            this.flowLayoutPanel2.Controls.Add(this.comboColonne);
            this.flowLayoutPanel2.Controls.Add(this.btnRecherche);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(92, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(324, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // rbtLigne
            // 
            this.rbtLigne.AutoSize = true;
            this.rbtLigne.Checked = true;
            this.rbtLigne.Location = new System.Drawing.Point(3, 3);
            this.rbtLigne.Name = "rbtLigne";
            this.rbtLigne.Size = new System.Drawing.Size(86, 17);
            this.rbtLigne.TabIndex = 0;
            this.rbtLigne.TabStop = true;
            this.rbtLigne.Text = "Ligne entière";
            this.rbtLigne.UseVisualStyleBackColor = true;
            // 
            // rbtColonne
            // 
            this.rbtColonne.AutoCheck = false;
            this.rbtColonne.AutoSize = true;
            this.rbtColonne.Location = new System.Drawing.Point(95, 3);
            this.rbtColonne.Name = "rbtColonne";
            this.rbtColonne.Size = new System.Drawing.Size(64, 17);
            this.rbtColonne.TabIndex = 1;
            this.rbtColonne.TabStop = true;
            this.rbtColonne.Text = "Colonne";
            this.rbtColonne.UseVisualStyleBackColor = true;
            // 
            // comboColonne
            // 
            this.comboColonne.FormattingEnabled = true;
            this.comboColonne.Location = new System.Drawing.Point(165, 3);
            this.comboColonne.Name = "comboColonne";
            this.comboColonne.Size = new System.Drawing.Size(48, 21);
            this.comboColonne.TabIndex = 2;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(219, 3);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "&Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // formRechercheDoublons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(480, 256);
            this.Controls.Add(this.flowComplet);
            this.MinimumSize = new System.Drawing.Size(450, 70);
            this.Name = "formRechercheDoublons";
            this.Text = "Outil de recherche de doublons";
            this.flowComplet.ResumeLayout(false);
            this.flowComplet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowSeparateur.ResumeLayout(false);
            this.flowColonnes.ResumeLayout(false);
            this.flowColonnes.PerformLayout();
            this.flowLigne.ResumeLayout(false);
            this.flowLigne.PerformLayout();
            this.flowRecherche.ResumeLayout(false);
            this.flowRecherche.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFichier;
        private System.Windows.Forms.TextBox tBxAdress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblColonnes;
        private System.Windows.Forms.TextBox tBxColonnes;
        private System.Windows.Forms.Label lblLignes;
        private System.Windows.Forms.TextBox tBxLigne;
        private System.Windows.Forms.Label lblChoixSeparateur;
        private System.Windows.Forms.ComboBox comboSeparateur;
        private System.Windows.Forms.FlowLayoutPanel flowComplet;
        private System.Windows.Forms.FlowLayoutPanel flowColonnes;
        private System.Windows.Forms.FlowLayoutPanel flowLigne;
        private System.Windows.Forms.FlowLayoutPanel flowSeparateur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowRecherche;
        private System.Windows.Forms.Label lblSel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbtLigne;
        private System.Windows.Forms.RadioButton rbtColonne;
        private System.Windows.Forms.ComboBox comboColonne;
        private System.Windows.Forms.Button btnRecherche;
    }
}

