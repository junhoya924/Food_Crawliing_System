using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FoodRecipe_disignProjectD
{

    public partial class AdvertiserPage : Form
    {
        string m_id;
        string m_content;
        int m_location = 0;
        MySqlConnection myConn;
        public void loadDB()
        {
            try
            {
                myConn = new MySqlConnection("Server=fani.iptime.org;Database=cookcrawling;userid=root;password=autoset;");
                myConn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("데이터베이스연결실패" + ex.Message);
            }


        }

        public void pageRefresh()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            loadDB();

            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM advertiser WHERE id = '" + m_id + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(row["name"], row["id"], row["age"]);
            }

            myConn.Close();


            loadDB();

            ds.Clear();
            ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM advertisement WHERE adverid = '" + m_id + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataGridView2.Rows.Add(row["content"], row["date"], row["adverid"], row["location"], row["isAllowed"]);
            }

            myConn.Close();
        }
        public AdvertiserPage(string id)
        {
            InitializeComponent();

            m_id = id;
            pageRefresh();

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_content = textBox1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            m_location = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            m_location = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDB();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string location = null;

            switch (m_location)
            {
                case 0:
                    location = "loginPage";
                    break;
                case 1:
                    location = "memberPage";
                    break;
                case 2:
                    location = "nonmemberPage";
                    break;
            }
            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            string temp = "INSERT INTO `advertisement`(`isallowed`, `content`, `date`, `adverid`, `location`)" +
                "VALUES ('0','" + m_content + "','" + date + "','" + m_id + "','" + location + "')";
            da = new MySqlDataAdapter(temp, myConn);
            da.Fill(ds);
            myConn.Close();

            pageRefresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
