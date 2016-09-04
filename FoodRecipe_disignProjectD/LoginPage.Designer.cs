namespace FoodRecipe_disignProjectD
{
    partial class LoginPage
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
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_administrator = new System.Windows.Forms.RadioButton();
            this.radioButton_member = new System.Windows.Forms.RadioButton();
            this.radioButton_nonMember = new System.Windows.Forms.RadioButton();
            this.radioButton_advertiser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(176, 131);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 21);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(85, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Recipe Crawling System ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(177, 174);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(149, 21);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input PASSWORD";
            // 
            // radioButton_administrator
            // 
            this.radioButton_administrator.Checked = true;
            this.radioButton_administrator.Location = new System.Drawing.Point(27, 35);
            this.radioButton_administrator.Name = "radioButton_administrator";
            this.radioButton_administrator.Size = new System.Drawing.Size(101, 16);
            this.radioButton_administrator.TabIndex = 0;
            this.radioButton_administrator.TabStop = true;
            this.radioButton_administrator.Text = "Administrator";
            this.radioButton_administrator.UseVisualStyleBackColor = true;
            this.radioButton_administrator.CheckedChanged += new System.EventHandler(this.radioButton_administrator_CheckedChanged);
            // 
            // radioButton_member
            // 
            this.radioButton_member.AutoSize = true;
            this.radioButton_member.Location = new System.Drawing.Point(27, 57);
            this.radioButton_member.Name = "radioButton_member";
            this.radioButton_member.Size = new System.Drawing.Size(70, 16);
            this.radioButton_member.TabIndex = 5;
            this.radioButton_member.Text = "Member";
            this.radioButton_member.UseVisualStyleBackColor = true;
            this.radioButton_member.CheckedChanged += new System.EventHandler(this.radioButton_member_CheckedChanged);
            // 
            // radioButton_nonMember
            // 
            this.radioButton_nonMember.AutoSize = true;
            this.radioButton_nonMember.Location = new System.Drawing.Point(27, 79);
            this.radioButton_nonMember.Name = "radioButton_nonMember";
            this.radioButton_nonMember.Size = new System.Drawing.Size(91, 16);
            this.radioButton_nonMember.TabIndex = 6;
            this.radioButton_nonMember.Text = "nonMember";
            this.radioButton_nonMember.UseVisualStyleBackColor = true;
            this.radioButton_nonMember.CheckedChanged += new System.EventHandler(this.radioButton_nonMember_CheckedChanged);
            // 
            // radioButton_advertiser
            // 
            this.radioButton_advertiser.AutoSize = true;
            this.radioButton_advertiser.Location = new System.Drawing.Point(27, 101);
            this.radioButton_advertiser.Name = "radioButton_advertiser";
            this.radioButton_advertiser.Size = new System.Drawing.Size(79, 16);
            this.radioButton_advertiser.TabIndex = 7;
            this.radioButton_advertiser.Text = "Advertiser";
            this.radioButton_advertiser.UseVisualStyleBackColor = true;
            this.radioButton_advertiser.CheckedChanged += new System.EventHandler(this.radioButton_advertisement_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_advertiser);
            this.groupBox1.Controls.Add(this.radioButton_nonMember);
            this.groupBox1.Controls.Add(this.radioButton_member);
            this.groupBox1.Controls.Add(this.radioButton_administrator);
            this.groupBox1.Location = new System.Drawing.Point(161, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Option";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(351, 129);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(96, 60);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(358, 227);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(88, 103);
            this.button_register.TabIndex = 10;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 21);
            this.textBox1.TabIndex = 11;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_administrator;
        private System.Windows.Forms.RadioButton radioButton_member;
        private System.Windows.Forms.RadioButton radioButton_nonMember;
        private System.Windows.Forms.RadioButton radioButton_advertiser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox1;
    }
}

