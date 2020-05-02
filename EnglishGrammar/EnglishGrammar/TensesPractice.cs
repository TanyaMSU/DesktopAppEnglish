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
    public partial class TensesPractice : Form
    {
        string pathToFile;
        QuestionsAnswersTenses infoFromFile;
        ThreeStrings currentTask;
        string pathToHappyImage;
        string pathToSadImage;

        public TensesPractice()
        {
            InitializeComponent();

            infoFromFile = new QuestionsAnswersTenses();
            pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VerbTenses.txt");
            infoFromFile.FillDataFromFile(pathToFile);

            pathToHappyImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "happy_horizontal.png");
            pathToSadImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sad_horizontal.png");

            label_task.TextAlign = ContentAlignment.MiddleCenter;
            label_task.Text = "Write the verbs in right tenses.\nSeparate multiple verbs by comma without spaces.\nExample: has already been done,will do";

            label_answer.TextAlign = ContentAlignment.MiddleCenter;
            label_answer.Text = "Good luck!";

            label_tenses.Text = "";

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
                    label_tenses.Text = "";

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
                    label_tenses.Text = "";

                    textBox1.Clear();

                    button_check_it.Text = "Check it!";
                    break;
            }


        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
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
                    case "p s":
                        fullTenses.Append("past simple, ");
                        break;
                    case "p c":
                        fullTenses.Append("past continuous, ");
                        break;
                    case "p p":
                        fullTenses.Append("past perfect, ");
                        break;
                    case "p p c":
                        fullTenses.Append("past perfect continuous, ");
                        break;
                    case "pr s":
                        fullTenses.Append("present simple, ");
                        break;
                    case "pr c":
                        fullTenses.Append("present continuous, ");
                        break;
                    case "pr p":
                        fullTenses.Append("present perfect, ");
                        break;
                    case "pr p c":
                        fullTenses.Append("present perfect continuous, ");
                        break;
                    case "f s":
                        fullTenses.Append("future simple, ");
                        break;
                    case "f c":
                        fullTenses.Append("future continuous, ");
                        break;
                    case "f p":
                        fullTenses.Append("future perfect, ");
                        break;
                    case "f p c":
                        fullTenses.Append("future perfect continuous, ");
                        break;
                }

            }
            label_tenses.Text = fullTenses.ToString().Substring(0, fullTenses.Length - 2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TensesGrammar form2 = new TensesGrammar();
            this.Enabled = false;
            form2.Show();
        }
    }
}
