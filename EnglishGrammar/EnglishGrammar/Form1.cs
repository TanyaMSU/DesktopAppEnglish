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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TensesGrammar form2 = new TensesGrammar();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TensesPractice form3 = new TensesPractice();
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassiveGrammar form4 = new PassiveGrammar();
            this.Hide();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PassivePractice form5 = new PassivePractice();
            this.Hide();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConditionsGrammar form6 = new ConditionsGrammar();
            this.Hide();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConditionsPractice form7 = new ConditionsPractice();
            this.Hide();
            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportedGrammar form8 = new ReportedGrammar();
            this.Hide();
            form8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportedPractice form9 = new ReportedPractice();
            this.Hide();
            form9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AboutForm form10 = new AboutForm();
            this.Hide();
            form10.Show();
        }
    }
}
