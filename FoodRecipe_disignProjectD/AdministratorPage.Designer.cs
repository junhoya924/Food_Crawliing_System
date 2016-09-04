namespace FoodRecipe_disignProjectD
{
    partial class AdministratorPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_RegisteredMember = new System.Windows.Forms.ListBox();
            this.listBox_notRegisteredMember = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_memberPage = new System.Windows.Forms.Button();
            this.button_dropOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.member_dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonmember_dataGridView = new System.Windows.Forms.DataGridView();
            this.name_non = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age_non = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_non = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_registerNon = new System.Windows.Forms.Button();
            this.button_DropOutNon = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_advertiser = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_dropOutAdvertisement = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_deleteAd = new System.Windows.Forms.Button();
            this.button_accessAd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.content_Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertiser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_QA = new System.Windows.Forms.ListBox();
            this.listBox_complaint = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonmember_dataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 1088);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 1088);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1424, 1050);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Look Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 683F));
            this.tableLayoutPanel1.Controls.Add(this.listBox_RegisteredMember, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox_notRegisteredMember, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.member_dataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nonmember_dataGridView, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.363296F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.6367F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1412, 1038);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listBox_RegisteredMember
            // 
            this.listBox_RegisteredMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_RegisteredMember.Font = new System.Drawing.Font("Gulim", 13F);
            this.listBox_RegisteredMember.FormattingEnabled = true;
            this.listBox_RegisteredMember.ItemHeight = 35;
            this.listBox_RegisteredMember.Location = new System.Drawing.Point(6, 67);
            this.listBox_RegisteredMember.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_RegisteredMember.Name = "listBox_RegisteredMember";
            this.listBox_RegisteredMember.Size = new System.Drawing.Size(633, 588);
            this.listBox_RegisteredMember.TabIndex = 0;
            this.listBox_RegisteredMember.SelectedIndexChanged += new System.EventHandler(this.listBox_RegisteredMember_SelectedIndexChanged);
            // 
            // listBox_notRegisteredMember
            // 
            this.listBox_notRegisteredMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_notRegisteredMember.Font = new System.Drawing.Font("Gulim", 13F);
            this.listBox_notRegisteredMember.FormattingEnabled = true;
            this.listBox_notRegisteredMember.ItemHeight = 35;
            this.listBox_notRegisteredMember.Location = new System.Drawing.Point(734, 67);
            this.listBox_notRegisteredMember.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_notRegisteredMember.Name = "listBox_notRegisteredMember";
            this.listBox_notRegisteredMember.Size = new System.Drawing.Size(672, 588);
            this.listBox_notRegisteredMember.TabIndex = 1;
            this.listBox_notRegisteredMember.SelectedIndexChanged += new System.EventHandler(this.listBox_notRegisteredMember_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_memberPage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_dropOut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 939);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(633, 93);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // button_memberPage
            // 
            this.button_memberPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_memberPage.Location = new System.Drawing.Point(6, 6);
            this.button_memberPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_memberPage.Name = "button_memberPage";
            this.button_memberPage.Size = new System.Drawing.Size(304, 81);
            this.button_memberPage.TabIndex = 0;
            this.button_memberPage.Text = "Member Page";
            this.button_memberPage.UseVisualStyleBackColor = true;
            // 
            // button_dropOut
            // 
            this.button_dropOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_dropOut.Location = new System.Drawing.Point(322, 6);
            this.button_dropOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_dropOut.Name = "button_dropOut";
            this.button_dropOut.Size = new System.Drawing.Size(305, 81);
            this.button_dropOut.TabIndex = 1;
            this.button_dropOut.Text = "Drop Out";
            this.button_dropOut.UseVisualStyleBackColor = true;
            this.button_dropOut.Click += new System.EventHandler(this.button_dropOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registered Member List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(734, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "NonRegistered Member List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 661);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(633, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Property";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(734, 661);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(672, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Property";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // member_dataGridView
            // 
            this.member_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.member_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.id});
            this.member_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.member_dataGridView.Location = new System.Drawing.Point(6, 707);
            this.member_dataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.member_dataGridView.Name = "member_dataGridView";
            this.member_dataGridView.RowTemplate.Height = 23;
            this.member_dataGridView.Size = new System.Drawing.Size(633, 182);
            this.member_dataGridView.TabIndex = 7;
            this.member_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nonmember_dataGridView
            // 
            this.nonmember_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonmember_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_non,
            this.age_non,
            this.id_non});
            this.nonmember_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nonmember_dataGridView.Location = new System.Drawing.Point(734, 707);
            this.nonmember_dataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nonmember_dataGridView.Name = "nonmember_dataGridView";
            this.nonmember_dataGridView.RowTemplate.Height = 23;
            this.nonmember_dataGridView.Size = new System.Drawing.Size(672, 182);
            this.nonmember_dataGridView.TabIndex = 8;
            this.nonmember_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nonmember_dataGridView_CellContentClick);
            // 
            // name_non
            // 
            this.name_non.HeaderText = "name";
            this.name_non.Name = "name_non";
            // 
            // age_non
            // 
            this.age_non.HeaderText = "age";
            this.age_non.Name = "age_non";
            // 
            // id_non
            // 
            this.id_non.HeaderText = "id";
            this.id_non.Name = "id_non";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_registerNon, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_DropOutNon, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(734, 939);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(672, 93);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // button_registerNon
            // 
            this.button_registerNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_registerNon.Location = new System.Drawing.Point(6, 6);
            this.button_registerNon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_registerNon.Name = "button_registerNon";
            this.button_registerNon.Size = new System.Drawing.Size(324, 81);
            this.button_registerNon.TabIndex = 0;
            this.button_registerNon.Text = "Register";
            this.button_registerNon.UseVisualStyleBackColor = true;
            this.button_registerNon.Click += new System.EventHandler(this.button_registerNon_Click);
            // 
            // button_DropOutNon
            // 
            this.button_DropOutNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DropOutNon.Location = new System.Drawing.Point(342, 6);
            this.button_DropOutNon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_DropOutNon.Name = "button_DropOutNon";
            this.button_DropOutNon.Size = new System.Drawing.Size(324, 81);
            this.button_DropOutNon.TabIndex = 1;
            this.button_DropOutNon.Text = "Drop Out";
            this.button_DropOutNon.UseVisualStyleBackColor = true;
            this.button_DropOutNon.Click += new System.EventHandler(this.button_DropOutNon_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1424, 1050);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Look Advertisement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.56962F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.43038F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel4.Controls.Add(this.listBox_advertiser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView3, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.33923F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66078F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1412, 1038);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // listBox_advertiser
            // 
            this.listBox_advertiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_advertiser.FormattingEnabled = true;
            this.listBox_advertiser.ItemHeight = 24;
            this.listBox_advertiser.Location = new System.Drawing.Point(6, 6);
            this.listBox_advertiser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_advertiser.Name = "listBox_advertiser";
            this.listBox_advertiser.Size = new System.Drawing.Size(1095, 502);
            this.listBox_advertiser.TabIndex = 0;
            this.listBox_advertiser.SelectedIndexChanged += new System.EventHandler(this.listBox_advertiser_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button_dropOutAdvertisement, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1164, 6);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(242, 502);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // button_dropOutAdvertisement
            // 
            this.button_dropOutAdvertisement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dropOutAdvertisement.Location = new System.Drawing.Point(6, 257);
            this.button_dropOutAdvertisement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_dropOutAdvertisement.Name = "button_dropOutAdvertisement";
            this.button_dropOutAdvertisement.Size = new System.Drawing.Size(230, 102);
            this.button_dropOutAdvertisement.TabIndex = 1;
            this.button_dropOutAdvertisement.Text = "Drop Out";
            this.button_dropOutAdvertisement.UseVisualStyleBackColor = true;
            this.button_dropOutAdvertisement.Click += new System.EventHandler(this.button_dropOutAdvertisement_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button_deleteAd, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_accessAd, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1164, 587);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(242, 445);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // button_deleteAd
            // 
            this.button_deleteAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_deleteAd.Location = new System.Drawing.Point(6, 6);
            this.button_deleteAd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_deleteAd.Name = "button_deleteAd";
            this.button_deleteAd.Size = new System.Drawing.Size(230, 104);
            this.button_deleteAd.TabIndex = 0;
            this.button_deleteAd.Text = "Delete Ad";
            this.button_deleteAd.UseVisualStyleBackColor = true;
            this.button_deleteAd.Click += new System.EventHandler(this.button_deleteAd_Click_1);
            // 
            // button_accessAd
            // 
            this.button_accessAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_accessAd.Location = new System.Drawing.Point(6, 228);
            this.button_accessAd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_accessAd.Name = "button_accessAd";
            this.button_accessAd.Size = new System.Drawing.Size(230, 144);
            this.button_accessAd.TabIndex = 1;
            this.button_accessAd.Text = "Allowed Ad";
            this.button_accessAd.UseVisualStyleBackColor = true;
            this.button_accessAd.Click += new System.EventHandler(this.button_accessAd_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.content_Ad,
            this.date_Ad,
            this.advertiser,
            this.location_Ad});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(6, 587);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(1095, 445);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // content_Ad
            // 
            this.content_Ad.HeaderText = "content";
            this.content_Ad.Name = "content_Ad";
            // 
            // date_Ad
            // 
            this.date_Ad.HeaderText = "date";
            this.date_Ad.Name = "date_Ad";
            // 
            // advertiser
            // 
            this.advertiser.HeaderText = "advertiser";
            this.advertiser.Name = "advertiser";
            // 
            // location_Ad
            // 
            this.location_Ad.HeaderText = "location";
            this.location_Ad.Name = "location_Ad";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Size = new System.Drawing.Size(1424, 1050);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Q&A";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.09303F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.906977F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel7.Controls.Add(this.listBox_QA, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.listBox_complaint, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 4, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1412, 1038);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // listBox_QA
            // 
            this.listBox_QA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_QA.FormattingEnabled = true;
            this.listBox_QA.ItemHeight = 24;
            this.listBox_QA.Location = new System.Drawing.Point(6, 6);
            this.listBox_QA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_QA.Name = "listBox_QA";
            this.listBox_QA.Size = new System.Drawing.Size(480, 1026);
            this.listBox_QA.TabIndex = 0;
            // 
            // listBox_complaint
            // 
            this.listBox_complaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_complaint.FormattingEnabled = true;
            this.listBox_complaint.ItemHeight = 24;
            this.listBox_complaint.Location = new System.Drawing.Point(540, 6);
            this.listBox_complaint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_complaint.Name = "listBox_complaint";
            this.listBox_complaint.Size = new System.Drawing.Size(410, 1026);
            this.listBox_complaint.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1001, 6);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(405, 1026);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // AdministratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 1088);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdministratorPage";
            this.Text = "Administrator Page";
            this.Load += new System.EventHandler(this.AdministratorPage_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.member_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonmember_dataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox_notRegisteredMember;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_memberPage;
        private System.Windows.Forms.Button button_dropOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView member_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView nonmember_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_non;
        private System.Windows.Forms.DataGridViewTextBoxColumn age_non;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_non;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_registerNon;
        private System.Windows.Forms.Button button_DropOutNon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox listBox_advertiser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_deleteAd;
        private System.Windows.Forms.Button button_accessAd;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn content_Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertiser;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_Ad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ListBox listBox_QA;
        private System.Windows.Forms.ListBox listBox_complaint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ListBox listBox_RegisteredMember;
        private System.Windows.Forms.Button button_dropOutAdvertisement;

    }
}