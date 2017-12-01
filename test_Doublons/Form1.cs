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
    public partial class Form1 : Form
    {

            
      

        private string fileAdress;
        int j, nbLigne;
        
        string[] decoupe;
       
        int colNb;
        Excel.Application xlsApp = new Excel.Application();
        StringComparer SC = StringComparer.Ordinal;
        StringComparer Test = StringComparer.Ordinal;
        
        Dictionary<string,int> listeControle=new Dictionary<string, int>();
        Workbook xlsWorkbook;
        public Form1()
        {
        
           
            InitializeComponent();
        }

        private void btnFichier_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileAdress = tBxAdress.Text = openFileDialog1.FileName;
                using (var reader = new StreamReader(fileAdress))
                {
                    var text = File.ReadAllLines(fileAdress);
                    colNb = text[0].Split(';').Count();
                    nbLigne = text.Length;
                     string[][] colonnes = new string[colNb][];
          
       
                    for (int line=0; line<text.Length;line++)
                    {
                        string myLine = text[line];
                        MessageBox.Show("la ligne >>"+myLine);
                        for (int i = 0; i < colNb; i++)
                        {
                            string leSplit = text[line].Substring(0, ';');
                            MessageBox.Show("la découpe >>"+leSplit);
                            colonnes[line][i] = text[line].Split(';')[i];
                            MessageBox.Show("la ligne >"+line+"< a la colonne >"+i+"< contient: "+colonnes[line][i]);
                        }
                    }
                    List<string> listeA = new List<string>();
                    while(!reader.EndOfStream)
                    {
                        var linQ = from line in text
                                   select line;
                        MessageBox.Show("la ligne = "+text);
                    }
                }
            }

        }

    }
}
