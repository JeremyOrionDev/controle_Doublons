using System;
using System.Collections.Generic;
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
        private string fileAdress;
        int[][] tableauComplet;
        int[][] lesDoublons;
        int nbLigne;
        List<string> lesSeparateurs = new List<string> { ",", ";", "/", "TAB", "-" };
        string fileName;
        string fileExt;
        char sep;
        int colNb;
        int[] lineSearch;
        string[] byLine;
        string[] text;
        string[] original;
        int[] leDoublon;
        List<int> aSupprimer = new List<int>();
        double chargement;
        string fileDirectory;
        StringComparer SC = StringComparer.Ordinal;
        StringComparer Test = StringComparer.Ordinal;
        public formRechercheDoublons()
        {
            InitializeComponent();
            dtgridResult.Visible = false;

            foreach (var item in lesSeparateurs)
            {
                comboSeparateur.Items.Add(item);
            }
        }

        private void btnFichier_Click(object sender, EventArgs e)
        {



            // Create an instance of the open file dialog box.
            openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileAdress = tBxAdress.Text = openFileDialog1.FileName;
                original = File.ReadAllLines(fileAdress);
      
                nbLigne = original.Count();
                flowLigne.Visible = true;
                flowSeparateur.Visible = true;
                FileInfo f = new FileInfo(fileAdress);
                fileName = f.Name;

                fileExt = f.Extension;
                tBxLigne.Text = nbLigne.ToString()+" lignes.";
                fileDirectory = f.DirectoryName;        

            }

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            int compteur = 0;

            string[] fichier = File.ReadAllLines(fileAdress);
            string myAdresse = @"C:\isra\" + fileName + "_sans_doublons" + fileExt;
          
     
            Boolean chercheLigne = true;
            if (rbtColonne.Checked) chercheLigne = false;
            if (chercheLigne)
            {
                text = original;
            }
            else
            {
                text = new string[nbLigne];
                for (int i = 0; i < nbLigne; i++)
                {
                    text[i] = original[i].Split(sep)[comboColonne.SelectedIndex+1];
                }
            }
            List<int> listeDbl = new List<int>();
            tableauComplet = new int[nbLigne][];
            int totalDoublons = 0;
            for (int i = 0; i < nbLigne; i++)
            {
                int nbDoublon = 0;
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
            lesDoublons = new int[listeDbl.Count()][];
            for (int i = 0; i < listeDbl.Count(); i++)
            {
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
            System.Data.DataTable DT = new System.Data.DataTable();
            DataRow DR;
            dtgridResult.Visible = true;

            DT.Columns.Add(new DataColumn("élément", typeof(string)));
            DT.Columns.Add(new DataColumn("Origine", typeof(string)));
            DT.Columns.Add(new DataColumn("Doublons", typeof(string)));
            List<int> doubles = new List<int>();
            for (int x = 0; x < lesDoublons.Count(); x++)
            {
                DR = DT.NewRow();
                string lines = "";

                DR[0] = text[lesDoublons[x][0]];
                DR[1] = lesDoublons[x][0]+1;

                for (int i = 1; i < lesDoublons[x].Count(); i++)
                {
                    doubles.Add(lesDoublons[x][0]);
                    if (!doubles.Contains(lesDoublons[x][i]))
                    {
                        doubles.Add(lesDoublons[x][i]);
                        lines = lines + (lesDoublons[x][i]+1) + ";";
                        aSupprimer.Add(lesDoublons[x][i]);
                    }

                }
                if (lines != "")
                {
                    DR[2] = lines;

                    DT.Rows.Add(DR);

                }

                //MessageBox.Show("l'élément "+x+" contient : "+lines);
                dtgridResult.DataSource = DT;
                dtgridResult.Height = dtgridResult.RowCount * 20 + 70;
                dtgridResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgridResult.Columns[1].Width = 400;
                dtgridResult.AutoSize = true;
                dtgridResult.Refresh();

            }
                

        }

        private void comboSeparateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboColonne.Items.Clear();
            sep = comboSeparateur.SelectedItem.ToString()[0];
            int nbCol = original[0].Split(sep).Count();
            this.tBxColonnes.Text = nbCol.ToString() + " colonnes.";
            this.flowColonnes.Visible = true;
            flowLigne.Visible = true;
            flowRecherche.Visible = true;
            for (int i = 0; i < nbCol; i++)
            {
                comboColonne.Items.Add(i+1);
            }
        }

        private void rbtLigne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtLigne.Checked==true)
            {
                rbtColonne.Checked = false;
            }
        }

        private void rbtColonne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtColonne.Checked==true)
            {
                rbtLigne.Checked = false;
            }
        }

        private void btnExportDoublons_Click(object sender, EventArgs e)
        {
            string[] export = new string[dtgridResult.Rows.Count];
            if (dtgridResult.Rows.Count==0)
            {
                MessageBox.Show("erreur le tableau est vide!");
            }
            else
            {
                string name=System.IO.Path.GetFileNameWithoutExtension(fileAdress);
                MessageBox.Show("directory = "+"\n"+fileDirectory+"\n"+name);
                string adress = fileDirectory + @"\" + name + "_export_doublons" + fileExt;
                TextWriter writer = new StreamWriter(adress);
                writer.Write("\t" + "élément " + "\t" + "|" + "\t" + "ligne Originale" + "\t" + "|" + "\t" + "Doublons" + "\t"+"\n");
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
                for (int i = 0; i < dtgridResult.Rows.Count ; i++)
                {
                    for (int j = 0; j < dtgridResult.Columns.Count; j++)
                    {
                        writer.Write("\t" + dtgridResult.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int num in aSupprimer )
            {
                
            }
        }
    }
    }


