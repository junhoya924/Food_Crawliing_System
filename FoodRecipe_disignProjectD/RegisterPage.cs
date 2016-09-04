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
    public partial class RegisterPage : Form
    {
        string m_name;
        string m_password;
        string m_id;
        int m_age;
        DataSet ds = new DataSet();
        bool[] m_checkAllInput = { false, false, false, false };

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
        int optiontype = 0;//

        public RegisterPage(MySqlConnection Conn,int option)
        {
            InitializeComponent();
            myConn = Conn;
            optiontype = option;//
        }
        /// <summary>
        /// ///////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_register_Click(object sender, EventArgs e)
        {
            if (optiontype == 2)
            {
                if (m_checkAllInput[0] == true && m_checkAllInput[1] == true && m_checkAllInput[2] == true && m_checkAllInput[3] == true)
                {
                    loadDB();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM user WHERE id='" + m_id + "'", myConn);
                    da.Fill(ds);
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (row["id"].ToString() == m_id.ToString())
                        {
                            MessageBox.Show("Already enrolled ID. Please Input another id");
                            return;
                        }
                    }
                    //MessageBox.Show(member_list.Items.ToString());

                    myConn.Close();
                    loadDB();

                    string temp = "INSERT INTO `user`(`name`, `id`, `password`, `age`, `isallowed`, `answer`) VALUES ('" + m_name + "','" + m_id + "','" + m_password + "','" + m_age + "','" + "0','0')";
                    MySqlCommand mc = new MySqlCommand(temp, myConn);
                    mc.ExecuteReader();

                    MessageBox.Show("Finish Register");
                    ds.Clear();
                    myConn.Close();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Input All data");
                }
            }
            else if (optiontype == 4)
            {
                if (m_checkAllInput[0] == true && m_checkAllInput[1] == true && m_checkAllInput[2] == true && m_checkAllInput[3] == true)
                {
                    loadDB();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM advertiser WHERE id='" + m_id + "'", myConn);
                    
                    da.Fill(ds);
                    da.Update(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (row["id"].ToString() == m_id.ToString())
                        {
                            MessageBox.Show("Already enrolled ID. Please Input another id");
                            return;
                        }
                    }
                    //MessageBox.Show(member_list.Items.ToString());
                    myConn.Close();
                    loadDB();
                    string temp = "INSERT INTO `advertiser`(`name`, `id`, `password`, `age`) VALUES ('" + m_name + "','" + m_id + "','" + m_password + "','" + m_age + "')";
                    MySqlCommand mc = new MySqlCommand(temp, myConn);
                    mc.ExecuteReader();

                    MessageBox.Show("Finish Register");
                    ds.Clear();
                    myConn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Input All data");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_name = name_textBox.Text;
            m_checkAllInput[0] = true;
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {
            m_id = id_textBox.Text;
            m_checkAllInput[1] = true;
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            m_password = password_textBox.Text;
            m_checkAllInput[2] = true;
        }

        private void age_textBox_TextChanged(object sender, EventArgs e)
        {
            m_age = System.Convert.ToInt16(age_textBox.Text.ToString());
            m_checkAllInput[3] = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
