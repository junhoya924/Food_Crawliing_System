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
    public partial class AdministratorPage : Form
    {

        int i = 0;
        string temp;
        int j = 0; //
        string memberTotal;
        string nonmemberTotal;
        string advertiserTotal; //

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
        public void qnaRefresh()
        {
            loadDB();
            listBox_QA.Items.Clear();
            listBox_complaint.Items.Clear();

            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = { "", "", "" };

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM user", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["answer"].ToString() != "0")
                {
                    splite = row["answer"].ToString().Split(delimiter);

                    if (splite[0] == "0")
                    {
                        listBox_QA.Items.Add(splite[1]);
                    }
                    else if (splite[0] == "1")
                    {
                        listBox_complaint.Items.Add(splite[1]);
                    }
                }
            }
            myConn.Close();
        }

        public void listRefresh()
        {
            loadDB();
            listBox_RegisteredMember.Items.Clear();
            listBox_notRegisteredMember.Items.Clear();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM user", myConn);
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                if (row["isallowed"].Equals(1))
                {
                    memberTotal = (++i).ToString();
                    listBox_RegisteredMember.Items.Add(memberTotal + "," + row["id"]);

                }
                else
                {
                    nonmemberTotal = (++i).ToString();
                    listBox_notRegisteredMember.Items.Add(nonmemberTotal + "," + row["id"]);
                    //member_dataGridView.Rows.Add(row["name"], row["age"], row["id"]);
                }

            }


        }
        /// <summary>
        /// /////////////////////////////
        /// </summary>
        public void advertiserlistRefresh()
        {
            loadDB();
            listBox_advertiser.Items.Clear();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM advertiser", myConn);


            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                advertiserTotal = (++j).ToString();
                listBox_advertiser.Items.Add(advertiserTotal + "," + row["id"]);
            }
            myConn.Close();
        }
        public AdministratorPage(MySqlConnection Conn)
        {
            myConn = Conn;

            InitializeComponent();

            listRefresh();

            advertiserlistRefresh(); //

            qnaRefresh();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox_RegisteredMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_RegisteredMember.SelectedItem == null)
                return;
            loadDB();
            member_dataGridView.Rows.Clear();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;
            splite = listBox_RegisteredMember.SelectedItem.ToString().Split(delimiter);
            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM user WHERE id = '" + splite[1] + "'", myConn);
            da.Fill(ds);



            foreach (DataRow row in ds.Tables[0].Rows)
            {
                member_dataGridView.Rows.Add(row["name"], row["age"], row["id"]);
            }

            myConn.Close();
        }

        private void nonmember_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox_notRegisteredMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_notRegisteredMember.SelectedItem == null)
                return;
            loadDB();
            nonmember_dataGridView.Rows.Clear();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;

            splite = listBox_notRegisteredMember.SelectedItem.ToString().Split(delimiter);
            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM user WHERE id = '" + splite[1] + "'", myConn);
            da.Fill(ds);



            foreach (DataRow row in ds.Tables[0].Rows)
            {
                nonmember_dataGridView.Rows.Add(row["name"], row["age"], row["id"]);


            }
            myConn.Close();
        }

        private void button_registerNon_Click(object sender, EventArgs e)
        {
            loadDB();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;
            splite = listBox_notRegisteredMember.SelectedItem.ToString().Split(delimiter);

            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            myConn.Close();
            // string temp = "UPDATE `user` SET `name` = , `id`, `password`, `age`, `isallowed`, `answer`) VALUES ('" + m_name + "','" + m_id + "','" + m_password + "','" + m_age + "','" + "0','0')";
            loadDB();
            da = new MySqlDataAdapter("SELECT *FROM user WHERE id = '" + splite[1] + "'", myConn);
            da.Fill(ds);



            foreach (DataRow row in ds.Tables[0].Rows)
            {
                nonmember_dataGridView.Rows.Add(row["name"], row["age"], row["id"]);
                temp = "UPDATE `user` SET `isallowed`='1' WHERE id ='" + row["id"] + "'";

                MessageBox.Show(temp.ToString());

                break;


            }

            MySqlCommand mc = new MySqlCommand(temp.ToString(), myConn);
            mc.ExecuteReader();
            listRefresh();
            myConn.Close();
        }

        private void listBox_advertiser_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDB();
            dataGridView3.Rows.Clear();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;
            splite = listBox_advertiser.SelectedItem.ToString().Split(delimiter);
            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM advertisement WHERE adverid = '" + splite[1] + "'", myConn);
            da.Fill(ds);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataGridView3.Rows.Add(row["content"], row["date"], row["adverid"], row["location"]);
            }
            myConn.Close();
        }

        private void button_dropOutAdvertisement_Click(object sender, EventArgs e)
        {
            loadDB();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;
            splite = listBox_advertiser.SelectedItem.ToString().Split(delimiter);


            string temp = "DELETE FROM `advertiser` WHERE id = '" + splite[1] + "'";
            MySqlCommand mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            advertiserlistRefresh();
            myConn.Close();

            loadDB();

            temp = "DELETE FROM `advertisement` WHERE adverid = '" + splite[1] + "'";
            mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            myConn.Close();

        }

        private void AdministratorPage_Load(object sender, EventArgs e)
        {

        }

        private void button_DropOutNon_Click(object sender, EventArgs e)
        {
            loadDB();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;
            splite = listBox_notRegisteredMember.SelectedItem.ToString().Split(delimiter);


            string temp = "DELETE FROM `user` WHERE id = '" + splite[1] + "'";
            MySqlCommand mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            listRefresh();
            myConn.Close();

            loadDB();

            temp = "DELETE FROM `scrabrecipe` WHERE userid = '" + splite[1] + "'";
            mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            myConn.Close();
        }

        private void button_dropOut_Click(object sender, EventArgs e)
        {
            loadDB();
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] splite = null;
            splite = listBox_RegisteredMember.SelectedItem.ToString().Split(delimiter);


            string temp = "DELETE FROM `user` WHERE id = '" + splite[1] + "'";
            MySqlCommand mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            listRefresh();
            myConn.Close();

            loadDB();

            temp = "DELETE FROM `scrabrecipe` WHERE userid = '" + splite[1] + "'";
            mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            myConn.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox_QA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button_deleteAd_Click_1(object sender, EventArgs e)
        {
            string content, date, locate, id;
            loadDB();
            int row = dataGridView3.CurrentCell.RowIndex;

            content = dataGridView3.Rows[row].Cells[0].Value.ToString();
            date = dataGridView3.Rows[row].Cells[1].Value.ToString();
            id = dataGridView3.Rows[row].Cells[2].Value.ToString();
            locate = dataGridView3.Rows[row].Cells[3].Value.ToString();

            temp = "DELETE FROM `advertisement` WHERE content = '" + content + "' AND date = '" + date + "' AND adverid = '" + id + "' AND location = '" + locate + "'";
            MySqlCommand mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            dataGridView3.Rows.RemoveAt(dataGridView3.CurrentCell.RowIndex);

            MessageBox.Show("delete complete");
            myConn.Close();
        }

        private void button_accessAd_Click_1(object sender, EventArgs e)
        {
            loadDB();

            MySqlDataAdapter da;
            DataSet ds = new DataSet();
            int rownum = dataGridView3.CurrentCell.RowIndex;

            da = new MySqlDataAdapter("SELECT *FROM advertisement WHERE content = '" + dataGridView3.Rows[rownum].Cells[0].Value.ToString() + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if ("0".Equals(row["isallowed"]))
                {
                    loadDB();

                    string temp = "UPDATE `advertisement` SET `isallowed` = '1' WHERE content = '" + dataGridView3.Rows[rownum].Cells[0].Value.ToString() + "'";
                    MySqlCommand mc = new MySqlCommand(temp, myConn);
                    mc.ExecuteReader();

                    myConn.Close();

                    MessageBox.Show("complete to allow");
                }
            }

            myConn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}