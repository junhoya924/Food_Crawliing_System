namespace FoodRecipe_disignProjectD
{
    partial class QAandComplainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.HeadLine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_QA = new System.Windows.Forms.RadioButton();
            this.radioButton_complain = new System.Windows.Forms.RadioButton();
            this.button_QAandComplainRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Any Question, Complaint?";
            // 
            // HeadLine
            // 
            this.HeadLine.AutoSize = true;
            this.HeadLine.Location = new System.Drawing.Point(50, 91);
            this.HeadLine.Name = "HeadLine";
            this.HeadLine.Size = new System.Drawing.Size(58, 12);
            this.HeadLine.TabIndex = 1;
            this.HeadLine.Text = "HeadLine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButton_QA
            // 
            this.radioButton_QA.AutoSize = true;
            this.radioButton_QA.Location = new System.Drawing.Point(55, 198);
            this.radioButton_QA.Name = "radioButton_QA";
            this.radioButton_QA.Size = new System.Drawing.Size(40, 16);
            this.radioButton_QA.TabIndex = 5;
            this.radioButton_QA.TabStop = true;
            this.radioButton_QA.Text = "Q&A";
            this.radioButton_QA.UseVisualStyleBackColor = true;
            this.radioButton_QA.CheckedChanged += new System.EventHandler(this.radioButton_QA_CheckedChanged);
            // 
            // radioButton_complain
            // 
            this.radioButton_complain.AutoSize = true;
            this.radioButton_complain.Location = new System.Drawing.Point(163, 198);
            this.radioButton_complain.Name = "radioButton_complain";
            this.radioButton_complain.Size = new System.Drawing.Size(80, 16);
            this.radioButton_complain.TabIndex = 6;
            this.radioButton_complain.TabStop = true;
            this.radioButton_complain.Text = "Complaint";
            this.radioButton_complain.UseVisualStyleBackColor = true;
            this.radioButton_complain.CheckedChanged += new System.EventHandler(this.radioButton_complain_CheckedChanged);
            // 
            // button_QAandComplainRegister
            // 
            this.button_QAandComplainRegister.Location = new System.Drawing.Point(88, 233);
            this.button_QAandComplainRegister.Name = "button_QAandComplainRegister";
            this.button_QAandComplainRegister.Size = new System.Drawing.Size(110, 29);
            this.button_QAandComplainRegister.TabIndex = 7;
            this.button_QAandComplainRegister.Text = "Register";
            this.button_QAandComplainRegister.UseVisualStyleBackColor = true;
            this.button_QAandComplainRegister.Click += new System.EventHandler(this.button_QAandComplainRegister_Click);
            // 
            // QAandComplainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 276);
            this.Controls.Add(this.button_QAandComplainRegister);
            this.Controls.Add(this.radioButton_complain);
            this.Controls.Add(this.radioButton_QA);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeadLine);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "QAandComplainPage";
            this.Text = "QAandComplainPage";
            this.Load += new System.EventHandler(this.QAandComplainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeadLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton_QA;
        private System.Windows.Forms.RadioButton radioButton_complain;
        private System.Windows.Forms.Button button_QAandComplainRegister;
    }
}