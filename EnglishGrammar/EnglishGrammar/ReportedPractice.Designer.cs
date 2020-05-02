namespace EnglishGrammar
{
    partial class ReportedPractice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportedPractice));
            this.label_question = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_rules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.Location = new System.Drawing.Point(191, 13);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(585, 112);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "They cut the gas off because Mr. and Mrs. Green hadn’t paid their bill.";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(191, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 105);
            this.textBox1.TabIndex = 1;
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(417, 239);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(129, 49);
            this.button_check.TabIndex = 2;
            this.button_check.Text = "Check it!";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_answer
            // 
            this.label_answer.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer.Location = new System.Drawing.Point(191, 301);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(585, 118);
            this.label_answer.TabIndex = 3;
            this.label_answer.Text = "They cut the gas off because Mr. and Mrs. Green hadn’t paid their bill.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 406);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_rules
            // 
            this.button_rules.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rules.Location = new System.Drawing.Point(661, 239);
            this.button_rules.Name = "button_rules";
            this.button_rules.Size = new System.Drawing.Size(115, 27);
            this.button_rules.TabIndex = 5;
            this.button_rules.Text = "Grammar rules";
            this.button_rules.UseVisualStyleBackColor = true;
            this.button_rules.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportedPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.button_rules);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportedPractice";
            this.Text = "Reported Speech : practice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_rules;
    }
}