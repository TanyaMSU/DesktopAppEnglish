using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishGrammar
{
    public partial class PassivePractice : Form
    {
        string pathToFile;
        QuestionsAnswers infoFromFile;
        TwoStrings currentTask;
        string pathToHappyImage;
        string pathToSadImage;


        public PassivePractice()
        {
            InitializeComponent();

            infoFromFile = new QuestionsAnswers();
            pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PassiveVoice.txt");
            infoFromFile.FillDataFromFile(pathToFile);

            pathToHappyImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "happy_vertical.png");
            pathToSadImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sad_vertical.png");

            label_question.TextAlign = ContentAlignment.MiddleCenter;
            label_question.Text = "Change the active voice into passive voice.\nLeave out the agent if it is not important.";

            label_answer.TextAlign = ContentAlignment.MiddleCenter;
            label_answer.Text = "Good luck!";

            button_check.Text = "Start!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_question.TextAlign = ContentAlignment.MiddleLeft;
            label_answer.TextAlign = ContentAlignment.MiddleLeft;

            switch (button_check.Text)
            {
                case "Start!":
                    currentTask = infoFromFile.GetRandomTask();
                    label_question.Text = currentTask.string1;
                    label_answer.Text = "";

                    button_check.Text = "Check it!";
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

                    button_check.Text = "next";
                    break;
                case "next":
                    currentTask = infoFromFile.GetRandomTask();
                    label_question.Text = currentTask.string1;
                    label_answer.Text = "";

                    textBox1.Clear();

                    button_check.Text = "Check it!";
                    break;
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassiveGrammar form4 = new PassiveGrammar();
            this.Enabled = false;
            form4.Show();
        }
    }
}
