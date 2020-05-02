using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishGrammar
{
    public partial class TensesGrammar : Form
    {
        public TensesGrammar()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Form mainForm = Application.OpenForms[0];
                mainForm.Show();
            }
            else
            {
                Application.OpenForms[1].Enabled = true;
            }
        }
    }
}
