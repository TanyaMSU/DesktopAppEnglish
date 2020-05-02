namespace EnglishGrammar
{
    partial class TensesPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TensesPractice));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_task = new System.Windows.Forms.Label();
            this.button_check_it = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.button_show_tenses = new System.Windows.Forms.Button();
            this.label_tenses = new System.Windows.Forms.Label();
            this.button_rules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 199);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(764, 61);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_task
            // 
            this.label_task.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_task.Location = new System.Drawing.Point(24, 18);
            this.label_task.Name = "label_task";
            this.label_task.Size = new System.Drawing.Size(764, 133);
            this.label_task.TabIndex = 1;
            this.label_task.Text = "A: What is that sound? B: A car alarm  _______ (ring) somewhere down the street. " +
    "It  _______ (drive) me crazy —I wish it would stop! It  _______ (ring) for more " +
    "than twenty minutes.";
            // 
            // button_check_it
            // 
            this.button_check_it.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check_it.Location = new System.Drawing.Point(330, 266);
            this.button_check_it.Name = "button_check_it";
            this.button_check_it.Size = new System.Drawing.Size(148, 62);
            this.button_check_it.TabIndex = 3;
            this.button_check_it.Text = "Check it!";
            this.button_check_it.UseVisualStyleBackColor = true;
            this.button_check_it.Click += new System.EventHandler(this.button_check_it_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 164);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_answer
            // 
            this.label_answer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_answer.Location = new System.Drawing.Point(24, 348);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(764, 72);
            this.label_answer.TabIndex = 2;
            this.label_answer.Text = "is ringing,is driving,has been ringing";
            // 
            // button_show_tenses
            // 
            this.button_show_tenses.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_tenses.Location = new System.Drawing.Point(24, 163);
            this.button_show_tenses.Name = "button_show_tenses";
            this.button_show_tenses.Size = new System.Drawing.Size(119, 30);
            this.button_show_tenses.TabIndex = 5;
            this.button_show_tenses.Text = "show tenses";
            this.button_show_tenses.UseVisualStyleBackColor = true;
            this.button_show_tenses.Click += new System.EventHandler(this.button_show_tenses_Click);
            // 
            // label_tenses
            // 
            this.label_tenses.AutoSize = true;
            this.label_tenses.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenses.Location = new System.Drawing.Point(143, 166);
            this.label_tenses.Name = "label_tenses";
            this.label_tenses.Size = new System.Drawing.Size(705, 22);
            this.label_tenses.TabIndex = 6;
            this.label_tenses.Text = "present perfect continuous, present perfect continuous, present perfect continuou" +
    "s";
            // 
            // button_rules
            // 
            this.button_rules.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rules.Location = new System.Drawing.Point(680, 266);
            this.button_rules.Name = "button_rules";
            this.button_rules.Size = new System.Drawing.Size(108, 23);
            this.button_rules.TabIndex = 7;
            this.button_rules.Text = "grammar rules";
            this.button_rules.UseVisualStyleBackColor = true;
            this.button_rules.Click += new System.EventHandler(this.button1_Click);
            // 
            // TensesPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 607);
            this.Controls.Add(this.button_rules);
            this.Controls.Add(this.label_tenses);
            this.Controls.Add(this.button_show_tenses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_check_it);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label_task);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TensesPractice";
            this.Text = "Verb Tenses : practice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_task;
        private System.Windows.Forms.Button button_check_it;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Button button_show_tenses;
        private System.Windows.Forms.Label label_tenses;
        private System.Windows.Forms.Button button_rules;
    }
}