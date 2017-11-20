namespace test_Doublons
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
            this.btnFichier = new System.Windows.Forms.Button();
            this.tBxAdress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblColonnes = new System.Windows.Forms.Label();
            this.tBxColonnes = new System.Windows.Forms.TextBox();
            this.lblLignes = new System.Windows.Forms.Label();
            this.tBxLigne = new System.Windows.Forms.TextBox();
            this.lblFeuille = new System.Windows.Forms.Label();
            this.tBxFeuilles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFichier
            // 
            this.btnFichier.Location = new System.Drawing.Point(21, 25);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(75, 23);
            this.btnFichier.TabIndex = 0;
            this.btnFichier.Text = "Fichier";
            this.btnFichier.UseVisualStyleBackColor = true;
            this.btnFichier.Click += new System.EventHandler(this.btnFichier_Click);
            // 
            // tBxAdress
            // 
            this.tBxAdress.Location = new System.Drawing.Point(134, 27);
            this.tBxAdress.Name = "tBxAdress";
            this.tBxAdress.ReadOnly = true;
            this.tBxAdress.Size = new System.Drawing.Size(241, 20);
            this.tBxAdress.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblColonnes
            // 
            this.lblColonnes.AutoSize = true;
            this.lblColonnes.Location = new System.Drawing.Point(18, 115);
            this.lblColonnes.Name = "lblColonnes";
            this.lblColonnes.Size = new System.Drawing.Size(51, 13);
            this.lblColonnes.TabIndex = 2;
            this.lblColonnes.Text = "Colonnes";
            // 
            // tBxColonnes
            // 
            this.tBxColonnes.Location = new System.Drawing.Point(134, 112);
            this.tBxColonnes.Name = "tBxColonnes";
            this.tBxColonnes.ReadOnly = true;
            this.tBxColonnes.Size = new System.Drawing.Size(241, 20);
            this.tBxColonnes.TabIndex = 3;
            // 
            // lblLignes
            // 
            this.lblLignes.AutoSize = true;
            this.lblLignes.Location = new System.Drawing.Point(18, 156);
            this.lblLignes.Name = "lblLignes";
            this.lblLignes.Size = new System.Drawing.Size(38, 13);
            this.lblLignes.TabIndex = 2;
            this.lblLignes.Text = "Lignes";
            // 
            // tBxLigne
            // 
            this.tBxLigne.Location = new System.Drawing.Point(134, 153);
            this.tBxLigne.Name = "tBxLigne";
            this.tBxLigne.ReadOnly = true;
            this.tBxLigne.Size = new System.Drawing.Size(241, 20);
            this.tBxLigne.TabIndex = 3;
            // 
            // lblFeuille
            // 
            this.lblFeuille.AutoSize = true;
            this.lblFeuille.Location = new System.Drawing.Point(18, 71);
            this.lblFeuille.Name = "lblFeuille";
            this.lblFeuille.Size = new System.Drawing.Size(42, 13);
            this.lblFeuille.TabIndex = 2;
            this.lblFeuille.Text = "Feuilles";
            // 
            // tBxFeuilles
            // 
            this.tBxFeuilles.Location = new System.Drawing.Point(134, 68);
            this.tBxFeuilles.Name = "tBxFeuilles";
            this.tBxFeuilles.ReadOnly = true;
            this.tBxFeuilles.Size = new System.Drawing.Size(241, 20);
            this.tBxFeuilles.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.tBxLigne);
            this.Controls.Add(this.tBxFeuilles);
            this.Controls.Add(this.tBxColonnes);
            this.Controls.Add(this.lblFeuille);
            this.Controls.Add(this.lblLignes);
            this.Controls.Add(this.lblColonnes);
            this.Controls.Add(this.tBxAdress);
            this.Controls.Add(this.btnFichier);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblFeuille;
        private System.Windows.Forms.TextBox tBxFeuilles;
    }
}

