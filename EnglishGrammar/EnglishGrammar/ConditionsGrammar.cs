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
    public partial class ConditionsGrammar : Form
    {
        public ConditionsGrammar()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }
    }
}
