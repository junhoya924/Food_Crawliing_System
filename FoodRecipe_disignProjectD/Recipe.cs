using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoodRecipe_disignProjectD
{
    public partial class Recipe : Form
    {
        string m_category, m_time, m_difficulty, m_ingredient, m_sauce;
        string[] m_content;

        public Recipe()
        {
            InitializeComponent();
        }

        public Recipe(string sort, string category, string time, string difficulty, string ingredient, string sauce, string[] content, int index)
        {
            InitializeComponent();
            m_content = new string[content.Length];
            m_category = sort + category;
            m_time = time;
            m_difficulty = difficulty;
            m_ingredient = ingredient;
            m_sauce = sauce;
            for (int i = 0; i < content.Length; i++)
                m_content[i] = content[i];

            category_textBox.Text = m_category;
            CookingTime_textBox.Text = m_time;
            Difficulty_textBox.Text = m_difficulty;
            richTextBox_ingredient.Text = m_ingredient;
            richTextBox_source.Text = m_sauce;

            for (int i = 0; i < m_content.Length; i++)
            {
                richTextBox_recipe.Text += m_content[i];
                richTextBox_recipe.Text += "\n";
            }

            if (index != -1)
            {
                pictureBox1.Load("D:\\DPCR\\" + index + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_recipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Recipe_Load(object sender, EventArgs e)
        {

        }

        private void category_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_source_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
