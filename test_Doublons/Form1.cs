using Microsoft.Office.Interop.Excel;
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
using Excel=Microsoft.Office.Interop.Excel;


namespace test_Doublons
{
    public partial class formRechercheDoublons : Form
    {
        private string fileAdress;
        int nbLigne;
        List<string> lesSeparateurs = new List<string> { ",", ";", "/", "TAB", "-" };       
        int colNb;
        string[] byLine;
        string[] text;
        List<int> lesDoublons = new List<int>();
        Excel.Application xlsApp = new Excel.Application();
        StringComparer SC = StringComparer.Ordinal;
        StringComparer Test = StringComparer.Ordinal;
        public formRechercheDoublons()
        {
            InitializeComponent();
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
                flowLigne.Visible = true;
                flowSeparateur.Visible = true;
                flowColonnes.Visible = true;
                flowRecherche.Visible = true;
                fileAdress = tBxAdress.Text = openFileDialog1.FileName;
               
                using (var reader = new StreamReader(fileAdress))
                {
                    text = File.ReadAllLines(fileAdress);
                    colNb = text[0].Split(';').Count();
                    nbLigne = text.Length;
                    tBxColonnes.Text = colNb + " colonnes";
                    tBxLigne.Text = nbLigne + " lignes";
                    string[][] colonnes = new string[colNb][];
                    byLine = new string[nbLigne];
                    for (int i = 0; i < colNb; i++)
                    {
                        colonnes[i] = new string[nbLigne];
                        comboColonne.Items.Add(i + 1);
                    }
       
                    for (int line=0; line<text.Length;line++)
                    {
                        byLine[line] = text[line];
                        string myLine = text[line];
                        //MessageBox.Show("la ligne >>"+myLine);
                        for (int i = 0; i < colNb; i++)
                        {
                            string leSplit = myLine.Split(';')[i];
                            colonnes[i][line] = leSplit;
                        }
                    }
  

                }
            }

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Boolean chercheLigne = true;
            if (rbtColonne.Checked) chercheLigne = false;
            if (chercheLigne)
            {
                for (int i = 0; i < byLine.Length; i++)
                {
                    for (int j = 0; j < byLine.Length; j++)
                    {
                        lesDoublons.Add(i);
                        if (text[i]==text[j])
                        {
                            lesDoublons.Add(j);
                        }
                    

                    }
                    myMessageBox MB;
                    int iRecherche = Array.IndexOf(text, text[i], i + 1);
                    if (i<iRecherche)
                    {

                        string XX = "doublon trouvé à la ligne >" + i + "< et >" + iRecherche + "< pour l'élément" + "\r\n" + " *** " + text[i] + " *** et" + "\r\n" + " --- " + text[iRecherche] + " --- ";
                        MB = new myMessageBox(XX);
                        Size size = TextRenderer.MeasureText(XX, MB.tbxRecu.Font);
                        MB.Width = size.Width;
                        MB.tbxRecu.Width = size.Width;
                        MB.tbxRecu.Height = size.Height*2;
                        MB.ShowDialog();
                    }
                }

            }

        }
    }
}
