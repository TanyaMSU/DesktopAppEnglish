using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishGrammar
{
    public partial class ConditionsPractice : Form
    {
        string pathToFile;
        QuestionsAnswersTenses infoFromFile;
        ThreeStrings currentTask;
        string pathToHappyImage;
        string pathToSadImage;

        public ConditionsPractice()
        {
            InitializeComponent();

            infoFromFile = new QuestionsAnswersTenses();
            pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConditionalForms.txt");
            infoFromFile.FillDataFromFile(pathToFile);

            pathToHappyImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "happy_horizontal.png");
            pathToSadImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sad_horizontal.png");

            label_task.TextAlign = ContentAlignment.MiddleCenter;
            label_task.Text = "Open the brackets to form conditionals.\nSeparate multiple verbs by comma without spaces.\nExample: were,would do";

            label_answer.TextAlign = ContentAlignment.MiddleCenter;
            label_answer.Text = "Good luck!";

            label3.Text = "";

            button_check_it.Text = "Start!";
            button_show_tenses.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button_check_it_Click(object sender, EventArgs e)
        {
            label_task.TextAlign = ContentAlignment.MiddleLeft;
            label_answer.TextAlign = ContentAlignment.MiddleLeft;

            switch (button_check_it.Text)
            {
                case "Start!":
                    currentTask = infoFromFile.GetRandomTask();
                    label_task.Text = currentTask.string1;
                    label_answer.Text = "";
                    label3.Text = "";

                    button_show_tenses.Enabled = true;
                    button_check_it.Text = "Check it!";
                    break;

                case "Check it!":
                    if (textBox1.Text.Equals(currentTask.string2))
                    {
                        pictureBox1.Image = Image.FromFile(pathToHappyImage);
                        label_answer.ForeColor = Color.Green;
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(pathToSadImage);
                        label_answer.ForeColor = Color.Red;
                    }
                    label_answer.Text = currentTask.string2;

                    button_check_it.Text = "next";
                    break;
                case "next":
                    currentTask = infoFromFile.GetRandomTask();
                    label_task.Text = currentTask.string1;
                    label_answer.Text = "";
                    label3.Text = "";

                    textBox1.Clear();

                    button_check_it.Text = "Check it!";
                    break;
            }


        }

        private void ConditionsPractice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void button_show_tenses_Click(object sender, EventArgs e)
        {
            string[] tenses = currentTask.string3.Split(',');
            StringBuilder fullTenses = new StringBuilder();

            foreach (string tense in tenses)
            {
                switch (tense)
                {
                    case "0":
                        fullTenses.Append("0 conditional (fact), ");
                        break;
                    case "1":
                        fullTenses.Append("1st conditional (A => B), ");
                        break;
                    case "2":
                        fullTenses.Append("2nd conditional (subjunctive mood), ");
                        break;
                    case "3":
                        fullTenses.Append("3d conditional (lost chance), ");
                        break;
                    case "m1":
                        fullTenses.Append("mixed1 conditional (result of past mistake), ");
                        break;
                    case "m2":
                        fullTenses.Append("mixed2 conditional (past result because of current situation), ");
                        break;
                }

            }
            label3.Text = fullTenses.ToString().Substring(0, fullTenses.Length - 2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TensesGrammar form2 = new TensesGrammar();
            this.Enabled = false;
            form2.Show();
        }
    }
}
