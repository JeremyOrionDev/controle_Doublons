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
        int j ;
        string[] decoupe;
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
                    var text = File.ReadAllLines(fileAdress).Select(part => part.Split(';'));
                    for (int i = 0; i < text.Count(); i++)
                    {
                        for (int j = 0; j < text.ElementAt(i).Count(); j++)
                        {
                            MessageBox.Show("ceci est le mot <"+(j+1)+"> de la ligne <"+(i+1)+"> et c'est >>"+text.ElementAt(i).ElementAt(j));
                        }
                    }
                    foreach (var item in text)
                    {
                        foreach (string word in item)
                        {

                        MessageBox.Show("un element = "+word);
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
