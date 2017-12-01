using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Doublons
{
    public partial class myMessageBox : Form
    {
        public myMessageBox(string text)
        {
            InitializeComponent();
            tbxRecu.Text = text;
            
        }
        

    }
}
