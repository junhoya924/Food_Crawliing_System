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
    public partial class makeRecipe : Form
    {
        string m_category, m_time, m_difficulty, m_ingredient, m_sauce;
        string m_content;
        string m_title;
        string m_id;
        bool[] allInput = { false, false, false, false, false, false, false };
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
        public makeRecipe(string id)
        {
            InitializeComponent();
            m_id = id;
        }

        private void category_textBox_make_TextChanged(object sender, EventArgs e)
        {
            m_category = category_textBox_make.Text;
            allInput[0] = true;
        }

        private void CookingTime_textBox_make_TextChanged(object sender, EventArgs e)
        {
            m_time = CookingTime_textBox_make.Text;
            allInput[1] = true;
        }

        private void Difficulty_textBox_make_TextChanged(object sender, EventArgs e)
        {
            m_difficulty = Difficulty_textBox_make.Text;
            allInput[2] = true;
        }

        private void richTextBox_ingredient_make_TextChanged(object sender, EventArgs e)
        {
            m_ingredient = richTextBox_ingredient_make.Text;
            allInput[3] = true;
        }

        private void richTextBox_source_make_TextChanged(object sender, EventArgs e)
        {
            m_sauce = richTextBox_source_make.Text;
            allInput[4] = true;
        }

        private void richTextBox_recipe_make_TextChanged(object sender, EventArgs e)
        {
            m_content = richTextBox_recipe_make.Text;
            allInput[5] = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (allInput[0] == true && allInput[1] == true && allInput[2] == true && allInput[3] == true
                && allInput[4] == true && allInput[5] == true && allInput[6] == true)
            {
                loadDB();
                string temp = "INSERT INTO `makerecipe`(`userid`, `title`, `category`, `cooktime`, `difficulty`, `ingredient`, `sauce`, `content`) VALUES ('" +
                    m_id + "','" + m_title + "','" + m_category + "','" + m_time + "','" + m_difficulty + "','" + m_ingredient + "', '" + m_sauce + "', '" + m_content + "')";
                MySqlCommand mc = new MySqlCommand(temp, myConn);
                mc.ExecuteReader();

                MessageBox.Show("Input Success");
                myConn.Close();
                Close();
                
            }
            else
            {
                MessageBox.Show("Input All data");
            }
        }


        private void textBox_title_TextChanged_1(object sender, EventArgs e)
        {
            m_title = textBox_title.Text;
            allInput[6] = true;
        }

        private void makeRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}