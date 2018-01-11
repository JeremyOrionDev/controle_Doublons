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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRechercheDoublons));
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
            this.flow3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPogress = new System.Windows.Forms.Panel();
            this.btnExportDoublons = new System.Windows.Forms.Button();
            this.btnExportFichier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelExport = new System.Windows.Forms.Panel();
            this.lblExportDoublons = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowComplet.SuspendLayout();
            this.panelFichier.SuspendLayout();
            this.flowSeparateur.SuspendLayout();
            this.flowColonnes.SuspendLayout();
            this.flowLigne.SuspendLayout();
            this.flowRecherche.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridResult)).BeginInit();
            this.flow3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFichier
            // 
            this.btnFichier.Font = new System.Drawing.Font("DejaVu Serif Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichier.Location = new System.Drawing.Point(3, 3);
            this.btnFichier.Margin = new System.Windows.Forms.Padding(3, 3, 70, 3);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(122, 34);
            this.btnFichier.TabIndex = 0;
            this.btnFichier.Text = "&Fichier";
            this.btnFichier.UseVisualStyleBackColor = true;
            this.btnFichier.Click += new System.EventHandler(this.BtnFichier_Click);
            // 
            // tBxAdress
            // 
            this.tBxAdress.Location = new System.Drawing.Point(135, 8);
            this.tBxAdress.Name = "tBxAdress";
            this.tBxAdress.ReadOnly = true;
            this.tBxAdress.Size = new System.Drawing.Size(324, 20);
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
            this.flowComplet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowComplet.Controls.Add(this.panelFichier);
            this.flowComplet.Controls.Add(this.flowSeparateur);
            this.flowComplet.Controls.Add(this.flowColonnes);
            this.flowComplet.Controls.Add(this.flowLigne);
            this.flowComplet.Controls.Add(this.flowRecherche);
            this.flowComplet.Controls.Add(this.flowLayoutPanel1);
            this.flowComplet.Controls.Add(this.dtgridResult);
            this.flowComplet.Controls.Add(this.flow3);
            this.flowComplet.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowComplet.Location = new System.Drawing.Point(12, 12);
            this.flowComplet.MinimumSize = new System.Drawing.Size(440, 40);
            this.flowComplet.Name = "flowComplet";
            this.flowComplet.Size = new System.Drawing.Size(674, 481);
            this.flowComplet.TabIndex = 6;
            this.flowComplet.WrapContents = false;
            // 
            // panelFichier
            // 
            this.panelFichier.AutoSize = true;
            this.panelFichier.Controls.Add(this.btnFichier);
            this.panelFichier.Controls.Add(this.tBxAdress);
            this.panelFichier.Location = new System.Drawing.Point(3, 3);
            this.panelFichier.Name = "panelFichier";
            this.panelFichier.Size = new System.Drawing.Size(462, 40);
            this.panelFichier.TabIndex = 11;
            // 
            // flowSeparateur
            // 
            this.flowSeparateur.AutoSize = true;
            this.flowSeparateur.Controls.Add(this.lblChoixSeparateur);
            this.flowSeparateur.Controls.Add(this.comboSeparateur);
            this.flowSeparateur.Location = new System.Drawing.Point(3, 49);
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
            this.flowColonnes.Location = new System.Drawing.Point(3, 84);
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
            this.flowLigne.Location = new System.Drawing.Point(3, 119);
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
            this.flowRecherche.Location = new System.Drawing.Point(3, 151);
            this.flowRecherche.Name = "flowRecherche";
            this.flowRecherche.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.flowRecherche.Size = new System.Drawing.Size(451, 56);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(356, 40);
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
            this.btnRecherche.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(231, 3);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(122, 34);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "&Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // dtgridResult
            // 
            this.dtgridResult.AllowUserToAddRows = false;
            this.dtgridResult.AllowUserToDeleteRows = false;
            this.dtgridResult.Location = new System.Drawing.Point(10, 219);
            this.dtgridResult.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dtgridResult.MultiSelect = false;
            this.dtgridResult.Name = "dtgridResult";
            this.dtgridResult.ReadOnly = true;
            this.dtgridResult.RowHeadersVisible = false;
            this.dtgridResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgridResult.Size = new System.Drawing.Size(420, 95);
            this.dtgridResult.TabIndex = 7;
            this.dtgridResult.Visible = false;
            // 
            // flow3
            // 
            this.flow3.AutoSize = true;
            this.flow3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flow3.Controls.Add(this.panel3);
            this.flow3.Controls.Add(this.panelExport);
            this.flow3.Controls.Add(this.panel2);
            this.flow3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow3.Location = new System.Drawing.Point(3, 320);
            this.flow3.Name = "flow3";
            this.flow3.Size = new System.Drawing.Size(668, 158);
            this.flow3.TabIndex = 18;
            // 
            // panelPogress
            // 
            this.panelPogress.Location = new System.Drawing.Point(261, 17);
            this.panelPogress.Name = "panelPogress";
            this.panelPogress.Size = new System.Drawing.Size(398, 20);
            this.panelPogress.TabIndex = 7;
            this.panelPogress.Visible = false;
            // 
            // btnExportDoublons
            // 
            this.btnExportDoublons.Font = new System.Drawing.Font("DejaVu Serif Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDoublons.Location = new System.Drawing.Point(375, 9);
            this.btnExportDoublons.Name = "btnExportDoublons";
            this.btnExportDoublons.Size = new System.Drawing.Size(110, 34);
            this.btnExportDoublons.TabIndex = 15;
            this.btnExportDoublons.Text = ">> Export";
            this.btnExportDoublons.UseVisualStyleBackColor = true;
            this.btnExportDoublons.Click += new System.EventHandler(this.btnExportDoublons_Click);
            // 
            // btnExportFichier
            // 
            this.btnExportFichier.Font = new System.Drawing.Font("DejaVu Serif Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFichier.Location = new System.Drawing.Point(375, 49);
            this.btnExportFichier.Name = "btnExportFichier";
            this.btnExportFichier.Size = new System.Drawing.Size(110, 34);
            this.btnExportFichier.TabIndex = 16;
            this.btnExportFichier.Text = ">> Fichier";
            this.btnExportFichier.UseVisualStyleBackColor = true;
            this.btnExportFichier.Click += new System.EventHandler(this.btnExportFichier_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(133, 3);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(122, 34);
            this.btnNouveau.TabIndex = 7;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(5, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 34);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "&Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(78, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(78, 3, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.panelPogress);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnNouveau);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 40);
            this.panel3.TabIndex = 7;
            // 
            // panelExport
            // 
            this.panelExport.Controls.Add(this.label1);
            this.panelExport.Controls.Add(this.btnExportFichier);
            this.panelExport.Controls.Add(this.btnExportDoublons);
            this.panelExport.Controls.Add(this.lblExportDoublons);
            this.panelExport.Location = new System.Drawing.Point(3, 49);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(488, 100);
            this.panelExport.TabIndex = 7;
            // 
            // lblExportDoublons
            // 
            this.lblExportDoublons.AutoSize = true;
            this.lblExportDoublons.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportDoublons.Location = new System.Drawing.Point(5, 14);
            this.lblExportDoublons.Name = "lblExportDoublons";
            this.lblExportDoublons.Size = new System.Drawing.Size(281, 22);
            this.lblExportDoublons.TabIndex = 0;
            this.lblExportDoublons.Text = "Exporter la liste des doublons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enregistrer le fichier sans doublons";
            // 
            // formRechercheDoublons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 592);
            this.Controls.Add(this.flowComplet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.flow3.ResumeLayout(false);
            this.flow3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelExport.ResumeLayout(false);
            this.panelExport.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportFichier;
        private System.Windows.Forms.FlowLayoutPanel flow3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPogress;
        private System.Windows.Forms.Button btnNouveau;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExportDoublons;
    }
}

