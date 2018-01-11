using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace test_Doublons
{
    public partial class formRechercheDoublons : Form
    {

        /// <summary>
        /// Liste du numero des lignes trouvées en double
        /// </summary>
        List<int> doubles = new List<int>();
        List<string> lesSeparateurs = new List<string> { ",", ";", "/", "TAB", "-" };

        //Déclaration des variables de type chaines
        private string fileAdress;
        string fileName, fileExt, fileDirectory;

        //Déclaration des variables de type tableau de chaines
        string[] text, original;

        StringCollection tableau;
        //Déclaration des tableau d'entiers
        int[][] tableauComplet, lesDoublons;

        //Délaration des entiers
        int nbLigne, nbCol;

        //Charactère séparateur sélectionné
        char sep;
        ProgressBar progress;

        public formRechercheDoublons()
        {
      
            InitializeComponent();
            flow3.Width = panelFichier.Width - 60;
            btnNouveau.Visible = false;
            panelExport.Visible = false;
            //Remplissage de la comboBox avec les séparateurs courants
            foreach (var item in lesSeparateurs)
            {
                comboSeparateur.Items.Add(item);
            }
        }

        private void videForm()
        {
            panelExport.Visible = false;
            dtgridResult.Visible = false;
            tBxAdress.Clear();
            foreach (TextBox item in this.Controls[0].Controls.Find("tBx*",true))
            {
                item.Text = "";
            }
            nbCol = 0; nbLigne = 0;
            original = new string[0];
            flowLigne.Visible = false;
            comboColonne.Items.Clear();
            flowColonnes.Visible = false;
            flowRecherche.Visible = false;
            flowSeparateur.Visible = false;
            dtgridResult.DataSource = "";
            dtgridResult.Refresh();
            //dtgridResult.Visible = false;

            panelPogress.Visible = false;
        }

        /// <summary>
        /// Méthode appelée au clic sur le bouton de sélection du fichier d'origine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFichier_Click(object sender, EventArgs e)
        {
            // Creation d'une instance de la boite de dialogue de sélection de fichier.
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();
            if (File.ReadAllLines(openFileDialog1.FileName).Count() == 0)
            {
                MessageBox.Show("Le fichier sélectionné est vide, il ne contient aucune ligne"+"\n"+"merci de choisir un fichier contenant des données","Erreur fichier",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            // Après validation du fichier sélectionné
            if (File.ReadAllLines(openFileDialog1.FileName).Count() != 0)
            {
                btnNouveau.Visible = true;
                //On récupère l'adresse du fichier d'origine et on l'affiche dans la textbox prévue à cet effet
                fileAdress = tBxAdress.Text = openFileDialog1.FileName;

                //Récupération du texte du fichier d'origine ligne par ligne
                original = File.ReadAllLines(fileAdress);
                
                //Adaptation de la taille de la textbox à la longueur de l'adresse du fichier
                tBxAdress.Width = fileAdress.Length * 20;
                Size size = TextRenderer.MeasureText(tBxAdress.Text, tBxAdress.Font);
                tBxAdress.Width = size.Width;

                //Récupération du nombre de lignes
                if (original[original.Count() - 1] == "")
                {
                    nbLigne = original.Count() - 1;
                }
                else nbLigne = original.Count();

                //Affichage des différentes zones
                flowLigne.Visible = true;
                flowSeparateur.Visible = true;

                //Récupération des informations du fichier (nom, extension et chemin)
                FileInfo f = new FileInfo(fileAdress);
                fileName = f.Name;
                fileExt = f.Extension;
                tBxLigne.Text = nbLigne.ToString() + " lignes.";
                fileDirectory = f.DirectoryName;

            } 


        }

        /// <summary>
        /// Méthode appelée lors de l'appui sur le bouton recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            //déclaration du booléen de type de recherche (ligne ou colonne) et modification en fonction du type de recherche
            Boolean chercheLigne = true;
            if (rbtColonne.Checked) chercheLigne = false;

            //Modification du fichier à analyser en fonction du mode de recherche
            if (chercheLigne)
            {
                text = original;
                panelExport.Visible = true;
                panelPogress.Visible = true;
            }
            else if (comboColonne.SelectedItem != null)
            {
                panelExport.Visible = true;
                panelPogress.Visible = true;
                text = new string[nbLigne];
                for (int i = 0; i < nbLigne; i++)
                {
                    text[i] = original[i].Split(sep)[comboColonne.SelectedIndex];
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une colonne.", "Erreur colonne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Création de la liste des doubles
                List<int> listeDbl = new List<int>();
            //Création du tableau des doublons complet de la taille du nombre de lignes
            tableau = new StringCollection();
            
            tableauComplet = new int[nbLigne][];
            //compteur de doublons trouvé par élément
            int totalDoublons = 0;
            progress= new ProgressBar();
            panelPogress.Controls.Add(progress);
            progress.Tag = "recherche";
            progress.Maximum = nbLigne-1;
            
            //Boucle de recherche
            for (int i = 0; i < nbLigne; i++)
            {
                int nbDoublon = 0;
                progress.Value = i;
                tableauComplet[i] = new int[10];
                for (int j = 0; j < nbLigne; j++)
                {
                    if (text[i] == text[j] && i != j)
                    {
                        if (!listeDbl.Contains(i))
                        {
                            listeDbl.Add(i);
                        }
                        totalDoublons++;
                        tableauComplet[i][nbDoublon] = j;
                        nbDoublon++;
                    }

                }
            }
            panelPogress.Controls.RemoveAt(0);
            progress = new ProgressBar();
            panelPogress.Controls.Add(progress);
            progress.Maximum = listeDbl.Count-1;
            //Création de la liste de doublons en fonction de leur nombre
            lesDoublons = new int[listeDbl.Count()][];
            //Boucle de remplissage du tableau de doublons
            for (int i = 0; i < listeDbl.Count(); i++)
            {
                progress.Value = i;
                List<int> tempDbl = new List<int>();
                for (int x = 0; x < 10; x++)
                {
                    if (tableauComplet[listeDbl[i]][x] != 0)
                    {
                        tempDbl.Add(tableauComplet[listeDbl[i]][x]);
                    }
                }

                int nbDoublon = tableauComplet[listeDbl[i]].Count();
                lesDoublons[i] = new int[tempDbl.Count() + 1];
                for (int j = 0; j < tempDbl.Count(); j++)
                {
                    lesDoublons[i][j] = tableauComplet[tempDbl[j]][j];
                    lesDoublons[i][j + 1] = tempDbl[j];
                }
            }
            panelPogress.Visible = false;
            //Si aucun doublon n'est trouvé on l'affiche
            if (lesDoublons.Count() == 0)
            {
                MessageBox.Show("Aucun doublon trouvé dans le fichier ");
            }
            else
            {
                //Création de la datatable affichant les résultats
                DataTable DT = new System.Data.DataTable();
                DataRow DR;
                dtgridResult.Visible = true;
                DT.Columns.Add(new DataColumn("élément", typeof(string)));
                DT.Columns.Add(new DataColumn("1er", typeof(string)));
                DT.Columns.Add(new DataColumn("Doublons", typeof(string)));

                //Boucle de remplissage de de la dataTable avec les doublons et numero de lignes
                for (int x = 0; x < lesDoublons.Count(); x++)
                {
                    DR = DT.NewRow();
                    string lines = "";
                    string texte = text[lesDoublons[x][0]];
                    int tailleTexte =0;
                    if( TextRenderer.MeasureText(texte, SystemFonts.DefaultFont).Width>tailleTexte)tailleTexte= TextRenderer.MeasureText(texte, SystemFonts.DefaultFont).Width;
                    if (tailleTexte+200<Screen.PrimaryScreen.WorkingArea.Width&&rbtLigne.Checked)
                    {
                        dtgridResult.Width = tailleTexte + 137;
                    }
                    else if (tailleTexte + 200 < Screen.PrimaryScreen.WorkingArea.Width && rbtColonne.Checked)
                    {
                        dtgridResult.Width = tailleTexte + 132;
                    }
                    DR[0] = texte;
                    DR[1] = lesDoublons[x][0] + 1;

                    for (int i = 0; i < lesDoublons[x].Count(); i++)
                    {
                        if (!doubles.Contains(lesDoublons[x][i]) && i != 0 && lesDoublons[x][i] > lesDoublons[x][i - 1])
                        {
                            doubles.Add(lesDoublons[x][i]);
                            lines = lines + (lesDoublons[x][i] + 1) + ";";
                        }
                    }
                    //Ajout des lignes qui contiennent des doublons uniquement
                    if (lines != "")
                    {
                        DR[2] = lines;
                        DT.Rows.Add(DR);
                    }
                }

                btnExportDoublons.Visible = true;

                btnExportFichier.Visible = true;
                dtgridResult.Refresh();
                if (lesDoublons.Count()>20)               
                {
                    this.Top = 0;
                    dtgridResult.Height =Screen.PrimaryScreen.WorkingArea.Height-400;                        
                    dtgridResult.ScrollBars = ScrollBars.Both;
                }
                flow3.Width = dtgridResult.Width;
                //Préparation de la dataGrid pour l'affichage 
                dtgridResult.DataSource = DT;
                if (dtgridResult.Rows.Count<=20)
                {

                    int htGrid = dtgridResult.ColumnHeadersHeight;
                    foreach (DataGridViewRow row in dtgridResult.Rows)
                    {
                        htGrid += row.Height;
                    }
                    dtgridResult.Height = htGrid+2;
                    //dtgridResult.Width = tailleT + 2;
                    dtgridResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dtgridResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dtgridResult.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

        }

        /// <summary>
        /// Méthode appelée lors du choix des séparateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboSeparateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboColonne.Items.Clear();
            //Récupération du séparateur choisi
            sep = comboSeparateur.SelectedItem.ToString()[0];

            //Vérification de l'existence du séparateur avec la première ligne du fichier à analyser
            if (original[1].IndexOf(sep) == -1)
            {
                MessageBox.Show("Erreur la ligne ne contient pas le séparateur sélectionné");
            }
            else
            {
                //Vérification du dernier caractère, si celui-ci est un séparateur et récupération du nombre de colonnes
                if (original[1].LastIndexOf(sep) == original[1].Length - 1)
                {
                    nbCol = (original[1].Split(sep).Count()) - 1;
                }
                else nbCol = original[1].Split(sep).Count();

                //Affichage du nombre de colonnes trouvées 
                this.tBxColonnes.Text = nbCol.ToString() + " colonnes.";
                this.flowColonnes.Visible = true;
                flowLigne.Visible = true;
                flowRecherche.Visible = true;
                flowComplet.AutoSize = true;
                //Ajout du nombre de colonne au sélecteur
                for (int i = 0; i < nbCol; i++)
                {
                    comboColonne.Items.Add(i + 1);
                }
            }

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            videForm();
        }


        private void rbtColonne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtColonne.Checked == true)
            {
                rbtLigne.Checked = false;
            }
        }

        /// <summary>
        /// Méthode appelée au clic sur le bouton export
        /// Création d'un tableau contenant les doublons trouvés avec les numéro de lignes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportDoublons_Click(object sender, EventArgs e)
        {
            //Création d'un tableau de chaine en fonction des résultats obtenus précédemment
            string[] export = new string[dtgridResult.Rows.Count];
            //Contrôle de l'existence de doublons
            if (dtgridResult.Rows.Count == 0)
            {
                MessageBox.Show("erreur le tableau est vide!");
            }
            else
            {
                //Récupération du nom du fichier et de l'adresse
                string name = Path.GetFileNameWithoutExtension(fileAdress);
                string adress = fileDirectory + @"\" + name + "_export_doublons" + fileExt;
                //Appel de l'outil d'écriture et formatage du fichier de sortie
                TextWriter writer = new StreamWriter(adress);
                writer.Write("\t" + "élément " + "\t" + "|" + "\t" + "ligne Originale" + "\t" + "|" + "\t" + "Doublons" + "\t" + "\n");
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
                //Boucle de remplissage du fichier
                for (int i = 0; i < dtgridResult.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgridResult.Columns.Count; j++)
                    {
                        writer.Write("\t" + dtgridResult.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Fichier contenant le tableau des doublons trouvés crée :" + "\n" + adress);
            }
        }
        /// <summary>
        /// Méthode appelée au clic sur le bouton d'export
        /// Création du fichier final sans doublon et enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportFichier_Click(object sender, EventArgs e)
        {
            //Création de la liste de chaines et boucle de remplissage
            List<string> textList = new List<string>();
            foreach (string item in text)
            {
                textList.Add(item);
            }
            int nb = text.Count();
            int reduc = 0;
            for (int i = 0; i < doubles.Count() - 1; i++)
            {
                int I = doubles[i] - reduc;
                textList.RemoveAt(I);
                reduc++;

            }
            //Récupération des infos de fichier et déclaration du nom de fichier de sortie
            string name = Path.GetFileNameWithoutExtension(fileAdress);
            string date = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
            string adress = fileDirectory + @"\" + name + "_export_sans_doublons_" + date + fileExt;
            //Utilisation de l'outil d'écriture 
            StreamWriter SW = new StreamWriter(adress,true,Encoding.UTF8);
           
            for (int i = 0; i < textList.Count(); i++)
            {
                SW.WriteLine(textList[i]);
            }
            SW.Close();
            if (MessageBox.Show("fichier enregistrer sous: " + "\n" + adress + "\n" + "Voulez-vous ouvrir le document crée?", "export terminé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(adress);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


