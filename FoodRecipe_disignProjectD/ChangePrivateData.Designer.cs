namespace FoodRecipe_disignProjectD
{
    partial class ChangePrivateData
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
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(75, 230);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(113, 21);
            this.textBox_age.TabIndex = 17;
            this.textBox_age.TextChanged += new System.EventHandler(this.textBox_age_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_password.Location = new System.Drawing.Point(76, 187);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(113, 21);
            this.textBox_password.TabIndex = 16;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(76, 138);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(113, 21);
            this.textBox_id.TabIndex = 15;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(76, 99);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(113, 21);
            this.textBox_name.TabIndex = 14;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(227, 85);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(20, 166);
            this.button_change.TabIndex = 18;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // ChangePrivateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 291);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChangePrivateData";
            this.Text = "ChangePrivateData";
            this.Load += new System.EventHandler(this.ChangePrivateData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_change;
    }
}