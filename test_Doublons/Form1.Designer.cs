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
            this.panelFichier = new System.Windows.Forms.Panel();
            this.flowSeparateur = new System.Windows.Forms.FlowLayoutPanel();
            this.flowColonnes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLigne = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRecherche = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtColonne = new System.Windows.Forms.RadioButton();
            this.rbtLigne = new System.Windows.Forms.RadioButton();
            this.comboColonne = new System.Windows.Forms.ComboBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgridResult = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExportDoublons = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowComplet.SuspendLayout();
            this.panelFichier.SuspendLayout();
            this.flowSeparateur.SuspendLayout();
            this.flowColonnes.SuspendLayout();
            this.flowLigne.SuspendLayout();
            this.flowRecherche.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridResult)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.comboSeparateur.SelectedIndexChanged += new System.EventHandler(this.comboSeparateur_SelectedIndexChanged);
            // 
            // flowComplet
            // 
            this.flowComplet.AutoSize = true;
            this.flowComplet.Controls.Add(this.panelFichier);
            this.flowComplet.Controls.Add(this.flowSeparateur);
            this.flowComplet.Controls.Add(this.flowColonnes);
            this.flowComplet.Controls.Add(this.flowLigne);
            this.flowComplet.Controls.Add(this.flowRecherche);
            this.flowComplet.Controls.Add(this.flowLayoutPanel1);
            this.flowComplet.Controls.Add(this.dtgridResult);
            this.flowComplet.Controls.Add(this.flowLayoutPanel3);
            this.flowComplet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowComplet.Location = new System.Drawing.Point(12, 12);
            this.flowComplet.MinimumSize = new System.Drawing.Size(440, 40);
            this.flowComplet.Name = "flowComplet";
            this.flowComplet.Size = new System.Drawing.Size(443, 511);
            this.flowComplet.TabIndex = 6;
            this.flowComplet.WrapContents = false;
            // 
            // panelFichier
            // 
            this.panelFichier.Controls.Add(this.btnFichier);
            this.panelFichier.Controls.Add(this.tBxAdress);
            this.panelFichier.Location = new System.Drawing.Point(3, 3);
            this.panelFichier.Name = "panelFichier";
            this.panelFichier.Size = new System.Drawing.Size(420, 30);
            this.panelFichier.TabIndex = 11;
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
            this.flowRecherche.Size = new System.Drawing.Size(404, 45);
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
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.comboColonne);
            this.flowLayoutPanel2.Controls.Add(this.btnRecherche);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(92, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(309, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtColonne);
            this.panel1.Controls.Add(this.rbtLigne);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 23);
            this.panel1.TabIndex = 4;
            // 
            // rbtColonne
            // 
            this.rbtColonne.AutoSize = true;
            this.rbtColonne.Location = new System.Drawing.Point(95, 3);
            this.rbtColonne.Name = "rbtColonne";
            this.rbtColonne.Size = new System.Drawing.Size(64, 17);
            this.rbtColonne.TabIndex = 1;
            this.rbtColonne.Text = "Colonne";
            this.rbtColonne.UseVisualStyleBackColor = true;
            this.rbtColonne.CheckedChanged += new System.EventHandler(this.rbtColonne_CheckedChanged);
            // 
            // rbtLigne
            // 
            this.rbtLigne.AutoSize = true;
            this.rbtLigne.Location = new System.Drawing.Point(3, 3);
            this.rbtLigne.Name = "rbtLigne";
            this.rbtLigne.Size = new System.Drawing.Size(86, 17);
            this.rbtLigne.TabIndex = 0;
            this.rbtLigne.Text = "Ligne entière";
            this.rbtLigne.UseVisualStyleBackColor = true;
            this.rbtLigne.CheckedChanged += new System.EventHandler(this.rbtLigne_CheckedChanged);
            // 
            // comboColonne
            // 
            this.comboColonne.FormattingEnabled = true;
            this.comboColonne.Location = new System.Drawing.Point(177, 3);
            this.comboColonne.Name = "comboColonne";
            this.comboColonne.Size = new System.Drawing.Size(48, 21);
            this.comboColonne.TabIndex = 2;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(231, 3);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "&Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 192);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // dtgridResult
            // 
            this.dtgridResult.AllowUserToAddRows = false;
            this.dtgridResult.AllowUserToDeleteRows = false;
            this.dtgridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgridResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgridResult.Location = new System.Drawing.Point(3, 198);
            this.dtgridResult.MultiSelect = false;
            this.dtgridResult.Name = "dtgridResult";
            this.dtgridResult.ReadOnly = true;
            this.dtgridResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgridResult.Size = new System.Drawing.Size(437, 95);
            this.dtgridResult.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnExportDoublons);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 299);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(420, 100);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // btnExportDoublons
            // 
            this.btnExportDoublons.Location = new System.Drawing.Point(3, 3);
            this.btnExportDoublons.Name = "btnExportDoublons";
            this.btnExportDoublons.Size = new System.Drawing.Size(118, 23);
            this.btnExportDoublons.TabIndex = 15;
            this.btnExportDoublons.Text = "exporter les doublons";
            this.btnExportDoublons.UseVisualStyleBackColor = true;
            this.btnExportDoublons.Click += new System.EventHandler(this.btnExportDoublons_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(127, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "export fichier sans doublons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formRechercheDoublons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(463, 591);
            this.Controls.Add(this.flowComplet);
            this.MinimumSize = new System.Drawing.Size(450, 70);
            this.Name = "formRechercheDoublons";
            this.Text = "Outil de recherche de doublons";
            this.flowComplet.ResumeLayout(false);
            this.flowComplet.PerformLayout();
            this.panelFichier.ResumeLayout(false);
            this.panelFichier.PerformLayout();
            this.flowSeparateur.ResumeLayout(false);
            this.flowColonnes.ResumeLayout(false);
            this.flowColonnes.PerformLayout();
            this.flowLigne.ResumeLayout(false);
            this.flowLigne.PerformLayout();
            this.flowRecherche.ResumeLayout(false);
            this.flowRecherche.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridResult)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.Panel panelFichier;
        private System.Windows.Forms.FlowLayoutPanel flowRecherche;
        private System.Windows.Forms.Label lblSel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbtLigne;
        private System.Windows.Forms.RadioButton rbtColonne;
        private System.Windows.Forms.ComboBox comboColonne;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgridResult;
        private System.Windows.Forms.Button btnExportDoublons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

