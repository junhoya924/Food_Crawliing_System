namespace FoodRecipe_disignProjectD
{
    partial class RegisterPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Member";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(69, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "age";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(72, 83);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(113, 21);
            this.name_textBox.TabIndex = 5;
            this.name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(72, 122);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(113, 21);
            this.id_textBox.TabIndex = 6;
            this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(72, 171);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(113, 21);
            this.password_textBox.TabIndex = 7;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(71, 214);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(113, 21);
            this.age_textBox.TabIndex = 8;
            this.age_textBox.TextChanged += new System.EventHandler(this.age_textBox_TextChanged);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(219, 67);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(22, 167);
            this.button_register.TabIndex = 9;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterPage";
            this.Text = "Register Page";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Button button_register;
    }
}