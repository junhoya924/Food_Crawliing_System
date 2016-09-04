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
    public partial class LoginPage : Form
    {
        string m_id;
        string m_password;
        int m_optionType = 1;
        /*
         * 0 = non
         * 1 = administrator
         * 2 = member
         * 3 = nonmember
         * 4 = advertiser
         */

        MySqlConnection myConn;
        
        public int M_optionType
        {
            get { return m_optionType; }
            set { m_optionType = value; }
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

        public LoginPage()
        {
            InitializeComponent();
            loadDB();
            m_id = " ";
            m_password = " ";

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM advertisement WHERE isallowed = '1' AND location = 'loginPage'", myConn);
            da.Fill(ds);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                textBox1.Text = row["content"].ToString();
            }
            myConn.Close();

        }

        ~LoginPage()
        {
            myConn.Close();

        }


        private void id_TextChanged(object sender, EventArgs e)
        {
            m_id = id.Text;

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            m_password = password.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
          /*  MySqlCommand selectCommand = new MySqlCommand();
            selectCommand.Connection = myConn;
            selectCommand.CommandText = "SELECT * FROM user";
            */
            int temp = 0;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM user", myConn);
            da.Fill(ds);


            switch (m_optionType)
            {
                case 1:

                    if (m_id == "root" && m_password == "admin")
                    {
                        AdministratorPage form_administrator = new AdministratorPage(myConn);
                        MessageBox.Show("Welcome Administrator");
                        form_administrator.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed.");
                    }

                    break;
                case 2:
                    temp = 0;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (m_id.Equals(row["id"]) && m_password.Equals(row["password"]))
                        {
                            MemberPage form_member = new MemberPage(m_id);
                            form_member.ShowDialog();
                            temp = 1;
                            break;
                        }
                        //MessageBox.Show(string.Format("이름 : {0} \n비고 : {1}", row["id"], row["password"]));
                    }
                    if (temp == 0)
                    {
                        MessageBox.Show("Login Failed");
                    }

                    break;
                case 3:

                    SearchPage form_search = new SearchPage();
                    form_search.ShowDialog();


                    break;
                case 4: //////
                    temp = 0;


                    DataSet dss = new DataSet();
                    MySqlDataAdapter daa = new MySqlDataAdapter("SELECT *FROM advertiser", myConn);
                    daa.Fill(dss);

                    foreach (DataRow row in dss.Tables[0].Rows)
                    {
                        if (m_id.Equals(row["id"]) && m_password.Equals(row["password"]))
                        {
                            AdvertiserPage form_advertiser = new AdvertiserPage(m_id);
                            form_advertiser.ShowDialog();
                            temp = 1;
                            break;
                        }
                        //MessageBox.Show(string.Format("이름 : {0} \n비고 : {1}", row["id"], row["password"]));
                    }
                    if (temp == 0)
                    {
                        MessageBox.Show("Login Failed");
                    }
                    break;
            }





        }

        private void radioButton_administrator_CheckedChanged(object sender, EventArgs e)
        {
            m_optionType = 1;

        }

        private void radioButton_nonMember_CheckedChanged(object sender, EventArgs e)
        {
            m_optionType = 3;
        }

        private void radioButton_member_CheckedChanged(object sender, EventArgs e)
        {
            m_optionType = 2;
        }

        private void radioButton_advertisement_CheckedChanged(object sender, EventArgs e)
        {
            m_optionType = 4;
        }

        private void button_register_Click(object sender, EventArgs e)
        {

            RegisterPage form_register = new RegisterPage(myConn,m_optionType);//
            form_register.ShowDialog();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //myConn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
