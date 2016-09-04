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
     

    public partial class ChangePrivateData : Form
    {
        string m_name;
        string m_password;
        string m_id;
        int m_age;
        DataSet ds = new DataSet();
        bool[] m_checkAllInput = { false, false, false, false };
        MySqlConnection myConn;
        string ownid;
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
        public ChangePrivateData(string _id)
        {
            InitializeComponent();
            ownid = _id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePrivateData_Load(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            m_name = textBox_name.Text;
            m_checkAllInput[0] = true;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            m_id = textBox_id.Text;
            m_checkAllInput[1] = true;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            m_password = textBox_password.Text;
            m_checkAllInput[2] = true;
        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {
            m_age = System.Convert.ToInt16(textBox_age.Text.ToString());
            m_checkAllInput[3] = true;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            loadDB();

            string temp = "UPDATE `user` SET `name` = '" + m_name + "', `id` = '" + m_id + "', `age` = '" + m_age + "' , `password` = '" + m_password + "' WHERE id = '" + ownid + "'";
            MySqlCommand mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            myConn.Close();

            MessageBox.Show("Change Complete");

            this.Close();
        }
    }
}
