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
    public partial class MemberPage : Form
    {
        string m_searchData;
        string m_id;
        int m_time = 0;
        int m_difficulty = 0;

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
        public MemberPage(string _id)
        {
            InitializeComponent();
            m_id = _id;
            textBox_name.Text = "id = " + m_id;

            loadDB();


            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM advertisement WHERE isallowed = '1' AND location = 'memberPage'", myConn);
            da.Fill(ds);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                textBox1.Text = row["content"].ToString();
            }
            myConn.Close();
        }

        private void button_chageData_Click(object sender, EventArgs e)
        {
            ChangePrivateData form_changeData = new ChangePrivateData(m_id);
            form_changeData.ShowDialog();
        }

        private void button_QAComplain_Click(object sender, EventArgs e)
        {
            QAandComplainPage form_QA = new QAandComplainPage(m_id);
            form_QA.ShowDialog();
        }

        private void button_mypage_Click(object sender, EventArgs e)
        {
            MyPage form_myPage = new MyPage(m_id);
            form_myPage.ShowDialog();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchPage form_searchPage = new SearchPage(m_searchData, m_time, m_difficulty, m_id);
            form_searchPage.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_searchData = textBox_search.Text;
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            
        }

        private void All_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_time = 0;
        }

        private void Intermediate_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_time = 2;
        }

        private void Advanced_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_time = 3;
        }

        private void Beginner_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_time = 1;
        }

        private void Alltime_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 0;
        }

        private void innerHalfOne_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 1;
        }

        private void innerOne_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 2;
        }

        private void aboveOne_radio_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 3;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
