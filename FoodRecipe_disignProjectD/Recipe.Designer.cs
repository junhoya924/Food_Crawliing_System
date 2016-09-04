namespace FoodRecipe_disignProjectD
{
    partial class Recipe
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.category_textBox = new System.Windows.Forms.TextBox();
            this.CookingTime_textBox = new System.Windows.Forms.TextBox();
            this.Difficulty_textBox = new System.Windows.Forms.TextBox();
            this.richTextBox_ingredient = new System.Windows.Forms.RichTextBox();
            this.richTextBox_source = new System.Windows.Forms.RichTextBox();
            this.richTextBox_recipe = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // category_textBox
            // 
            this.category_textBox.Enabled = false;
            this.category_textBox.Location = new System.Drawing.Point(474, 24);
            this.category_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(283, 35);
            this.category_textBox.TabIndex = 1;
            this.category_textBox.TextChanged += new System.EventHandler(this.category_textBox_TextChanged);
            // 
            // CookingTime_textBox
            // 
            this.CookingTime_textBox.Enabled = false;
            this.CookingTime_textBox.Location = new System.Drawing.Point(474, 78);
            this.CookingTime_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CookingTime_textBox.Name = "CookingTime_textBox";
            this.CookingTime_textBox.Size = new System.Drawing.Size(281, 35);
            this.CookingTime_textBox.TabIndex = 2;
            // 
            // Difficulty_textBox
            // 
            this.Difficulty_textBox.Enabled = false;
            this.Difficulty_textBox.Location = new System.Drawing.Point(474, 132);
            this.Difficulty_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Difficulty_textBox.Name = "Difficulty_textBox";
            this.Difficulty_textBox.Size = new System.Drawing.Size(281, 35);
            this.Difficulty_textBox.TabIndex = 3;
            // 
            // richTextBox_ingredient
            // 
            this.richTextBox_ingredient.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox_ingredient.Location = new System.Drawing.Point(32, 256);
            this.richTextBox_ingredient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox_ingredient.Name = "richTextBox_ingredient";
            this.richTextBox_ingredient.ReadOnly = true;
            this.richTextBox_ingredient.Size = new System.Drawing.Size(721, 132);
            this.richTextBox_ingredient.TabIndex = 4;
            this.richTextBox_ingredient.Text = "";
            // 
            // richTextBox_source
            // 
            this.richTextBox_source.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox_source.Location = new System.Drawing.Point(32, 450);
            this.richTextBox_source.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox_source.Name = "richTextBox_source";
            this.richTextBox_source.ReadOnly = true;
            this.richTextBox_source.Size = new System.Drawing.Size(721, 168);
            this.richTextBox_source.TabIndex = 5;
            this.richTextBox_source.Text = "";
            this.richTextBox_source.TextChanged += new System.EventHandler(this.richTextBox_source_TextChanged);
            // 
            // richTextBox_recipe
            // 
            this.richTextBox_recipe.Location = new System.Drawing.Point(32, 698);
            this.richTextBox_recipe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox_recipe.Name = "richTextBox_recipe";
            this.richTextBox_recipe.ReadOnly = true;
            this.richTextBox_recipe.Size = new System.Drawing.Size(721, 498);
            this.richTextBox_recipe.TabIndex = 6;
            this.richTextBox_recipe.Text = "";
            this.richTextBox_recipe.TextChanged += new System.EventHandler(this.richTextBox_recipe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "CookingTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingredient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Source Ingredient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 668);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Recipe";
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 1224);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_recipe);
            this.Controls.Add(this.richTextBox_source);
            this.Controls.Add(this.richTextBox_ingredient);
            this.Controls.Add(this.Difficulty_textBox);
            this.Controls.Add(this.CookingTime_textBox);
            this.Controls.Add(this.category_textBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Recipe";
            this.Text = "Recipe";
            this.Load += new System.EventHandler(this.Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox category_textBox;
        private System.Windows.Forms.TextBox CookingTime_textBox;
        private System.Windows.Forms.TextBox Difficulty_textBox;
        private System.Windows.Forms.RichTextBox richTextBox_ingredient;
        private System.Windows.Forms.RichTextBox richTextBox_source;
        private System.Windows.Forms.RichTextBox richTextBox_recipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}