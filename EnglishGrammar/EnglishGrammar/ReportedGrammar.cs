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
    public partial class ReportedGrammar : Form
    {
        public ReportedGrammar()
        {
            InitializeComponent();
        }

        private void ReportedGrammar_FormClosed(object sender, FormClosedEventArgs e)
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
