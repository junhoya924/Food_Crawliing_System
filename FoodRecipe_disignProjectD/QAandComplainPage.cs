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
    public partial class QAandComplainPage : Form
    {
        MySqlConnection myConn;
        string m_id;
        string title;
        string content;
        bool[] m_checkAllInput = { false, false };
        int radio = -1;
        /*
         * 0.QA
         * 1.Complain
         */

        public QAandComplainPage(string _id)
        {
            InitializeComponent();
            m_id = _id;
        }

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

        private void QAandComplainPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            title = textBox1.Text;
            m_checkAllInput[0] = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            content = textBox2.Text;
            m_checkAllInput[1] = true;
        }

        private void radioButton_QA_CheckedChanged(object sender, EventArgs e)
        {
            radio = 0;
        }

        private void radioButton_complain_CheckedChanged(object sender, EventArgs e)
        {
            radio = 1;
        }

        private void button_QAandComplainRegister_Click(object sender, EventArgs e)
        {
            loadDB();

            if (m_checkAllInput[0] == true && m_checkAllInput[1] == true && radio != -1)
            {
                string temp = "UPDATE `user` SET `answer` = '" + radio.ToString() + ',' + title + ',' + content + "'WHERE id = '" + m_id + "'";
                MySqlCommand mc = new MySqlCommand(temp, myConn);
                mc.ExecuteReader();

                myConn.Close();

                MessageBox.Show("Change Complete");

                this.Close();
            }
            else
            {
                MessageBox.Show("Input All data");
            }
        }
    }
}
