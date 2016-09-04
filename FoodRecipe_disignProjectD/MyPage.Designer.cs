namespace FoodRecipe_disignProjectD
{
    partial class MyPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_clipList = new System.Windows.Forms.ListBox();
            this.listBox_wrotenList = new System.Windows.Forms.ListBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBox_clipList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox_wrotenList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_write, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Refresh, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.201058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.79894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 864);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBox_clipList
            // 
            this.listBox_clipList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_clipList.FormattingEnabled = true;
            this.listBox_clipList.ItemHeight = 24;
            this.listBox_clipList.Location = new System.Drawing.Point(6, 71);
            this.listBox_clipList.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_clipList.Name = "listBox_clipList";
            this.listBox_clipList.Size = new System.Drawing.Size(416, 722);
            this.listBox_clipList.TabIndex = 0;
            this.listBox_clipList.SelectedIndexChanged += new System.EventHandler(this.listBox_clipList_SelectedIndexChanged);
            this.listBox_clipList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_clipList_MouseDoubleClick);
            // 
            // listBox_wrotenList
            // 
            this.listBox_wrotenList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_wrotenList.FormattingEnabled = true;
            this.listBox_wrotenList.ItemHeight = 24;
            this.listBox_wrotenList.Location = new System.Drawing.Point(434, 71);
            this.listBox_wrotenList.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_wrotenList.Name = "listBox_wrotenList";
            this.listBox_wrotenList.Size = new System.Drawing.Size(416, 722);
            this.listBox_wrotenList.TabIndex = 1;
            this.listBox_wrotenList.SelectedIndexChanged += new System.EventHandler(this.listBox_wrotenList_SelectedIndexChanged);
            this.listBox_wrotenList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_wrotenList_MouseDoubleClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_name.Enabled = false;
            this.textBox_name.Location = new System.Drawing.Point(6, 6);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(416, 35);
            this.textBox_name.TabIndex = 2;
            // 
            // button_write
            // 
            this.button_write.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_write.Location = new System.Drawing.Point(434, 805);
            this.button_write.Margin = new System.Windows.Forms.Padding(6);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(416, 53);
            this.button_write.TabIndex = 3;
            this.button_write.Text = "Write";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // Refresh
            // 
            this.Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Refresh.Location = new System.Drawing.Point(6, 805);
            this.Refresh.Margin = new System.Windows.Forms.Padding(6);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(416, 53);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 864);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MyPage";
            this.Text = "MyPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox_clipList;
        private System.Windows.Forms.ListBox listBox_wrotenList;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button Refresh;
    }
}