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

        Boolean estOuvert;

        private string fileAdress;
        int j ;
        string[] decoupe;
        Excel.Application xlsApp = new Excel.Application();
        StringComparer SC = StringComparer.Ordinal;
        StringComparer Test = StringComparer.Ordinal;
        
        Dictionary<string,int> colonne1=new Dictionary<string, int>();
        Dictionary<string, int> doublons1 = new Dictionary<string, int>();
        Dictionary<string, int> colonne2 = new Dictionary<string, int>();
        Dictionary<string, int> doublons2 = new Dictionary<string, int>();
        Dictionary<string, int> colonne3 = new Dictionary<string, int>();
        Dictionary<string, int> doublons3 = new Dictionary<string, int>();
        Dictionary<string, int> colonne4 = new Dictionary<string, int>();
        Dictionary<string, int> doublons4 = new Dictionary<string, int>();
        Workbook xlsWorkbook;
        public Form1()
        {
    
            //MessageBox.Show("le resultat de la comparaison:: " + Test.Compare("Bonjour mlle, comment allez vous?", "Bonjour mlle, comment allez vous?"));
            InitializeComponent();
        }
        /// <summary>
        /// Check wether a file is locked
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
        private void btnFichier_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileAdress = tBxAdress.Text = openFileDialog1.FileName;
                FileInfo F = new FileInfo(fileAdress);
                if (IsFileLocked(F))
                {
                    MessageBox.Show("fichier deja ouvert");
                    xlsApp.Workbooks.Close();
                }

                xlsWorkbook = xlsApp.Workbooks.Open(fileAdress, Type.Missing);



                _Worksheet xlsWorksheet = xlsWorkbook.Sheets[xlsWorkbook.Sheets.Count];
                Range range = xlsWorksheet.UsedRange;
                tBxFeuilles.Text = xlsWorksheet.Name;
                tBxColonnes.Text = range.Columns.Count.ToString();
                tBxLigne.Text = range.Rows.Count.ToString();
                Excel.Worksheet export;
                export = (Excel.Worksheet)xlsWorkbook.Worksheets.Add();
                MessageBox.Show("test colonne 1 ligne 25 ..." + range.Columns[1].cells[25].value);
                for (int i = 1; i <= range.Columns.Count; i++)
                {
                    
                    for (int j = 1; j <= range.Columns[i].cells.Count; j++)
                    {
                        for (int k = 1; k <= range.Columns[i].cells.Count; k++)
                        {
                            if (j != range.Columns[i].cells.Count && j != k)
                            {

                                if (range.Columns[i].cells[j].value is string && range.Columns[i].cells[k].value is string)
                                {
                                    if (SC.Compare(range.Columns[i].cells[j].value, range.Columns[i].cells[k].value) == 0)
                                    {
                                        MessageBox.Show("les cellules " + j + " et " + k + " sont identiques " + "\n" + range.Columns[i].cells[j].value + "\n" + range.Columns[i].cells[k].value);
                                        range.Columns.Insert(i);
                                        range.Columns[i + 1].cells[j].Value2 = "doublons ligne =" + k;
                                        range.Columns[i + 1].cells[k].value = "doublon ligne =" + j;
                                        
                                    }
                                }

                                if (range.Columns[i].cells[j].value is double && range.Columns[i].cells[k].value is double )
                                {
                                    double D1 = range.Columns[i].cells[j].value;
                                    double D2 = range.Columns[i].cells[k].value;
                                    if (D1==D2)
                                    {
                                        MessageBox.Show("les cellules " + j + " et " + k + " sont identiques " + "\n" + range.Columns[i].cells[j].value + "\n" + range.Columns[i].cells[k].value);
                                    }
                                }



                            }
                            
                        }
                    }
                    
                    {

                    }
                }

                xlsWorkbook.Save();
                xlsWorkbook.Close(fileAdress);
                MessageBox.Show("fin des tests");

            }

        }

    }
}
