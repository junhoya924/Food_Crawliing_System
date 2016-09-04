using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Net;
using System.Web;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FoodRecipe_disignProjectD
{
    public partial class MyPage : Form
    {
        string m_id;
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

        public void cliplistRefresh()
        {
            loadDB();
            listBox_clipList.Items.Clear();

            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM scrabrecipe WHERE userid = '" + m_id + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox_clipList.Items.Add(row["title"].ToString());
            }

            myConn.Close();
        }

        public void makelistRefresh()
        {
            loadDB();
            listBox_wrotenList.Items.Clear();

            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM makerecipe WHERE userid = '" + m_id + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox_wrotenList.Items.Add(row["title"].ToString());
            }

            myConn.Close();
        }

        public MyPage(string _id)
        {
            InitializeComponent();
            m_id = _id;
            cliplistRefresh();
            makelistRefresh();
        }

        private void listBox_clipList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void listBox_clipList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadDB();
            string t = listBox_clipList.SelectedItem.ToString();
            string url;


            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM scrabrecipe WHERE title = '" + t + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                url = row["recipeurl"].ToString();

                string sort = null;
                string group = null;
                string time = null;
                string difficulty = null;
                string ingredient = null;
                string sauce = null;
                string[] content = null;
                string[] truecontent = null;
                string subcontent;
                int idx = 0;
                int ii = 0;
                WebClient w = new WebClient();
                w.Encoding = Encoding.UTF8;
                string html = w.DownloadString(url);

                Regex sortregex = new Regex(@"""selector_class"">(?<sort>[ㄱ-힣\W]*)</a>");
                MatchCollection mc = sortregex.Matches(html);
                sort = mc[0].Groups["sort"].ToString();

                Regex groupregex = new Regex(@"""UI.toolTip\(event\)"">(?<group>[ㄱ-힣\W]*)</a>");
                mc = groupregex.Matches(html);
                group = mc[0].Groups["group"].ToString();

                Regex timeregex = new Regex(@"""selector_time"" onclick=""return false;"" >(?<time>[0-9ㄱ-힣\s]*)</a>");
                mc = timeregex.Matches(html);
                time = mc[0].Groups["time"].ToString();

                Regex difficultyregex = new Regex(@"""selector_difficulty"" onclick=""return false;"" >(?<difficulty>[ㄱ-힣]*)</a>");
                mc = difficultyregex.Matches(html);
                difficulty = mc[0].Groups["difficulty"].ToString();

                Regex ingredientregex = new Regex(@"요리재료</dt><dd class=""stuff"">(?<ingredient>[0-9ㄱ-힣\W\sa-z]*)<dt class=""first source"">");
                mc = ingredientregex.Matches(html);
                ingredient = mc[0].Groups["ingredient"].ToString();
                ingredient = ingredient.Replace("<br>", "\n");
                ingredient = ingredient.Replace("</dd>", "");

                Regex sauceregex = new Regex(@"소스재료</dt><dd class=""stuff"">(?<sauce>[0-9ㄱ-힣\W\sa-z]*)</dd>\s*<dt class=""nobottom");
                mc = sauceregex.Matches(html);
                sauce = mc[0].Groups["sauce"].ToString();
                sauce = sauce.Replace("<br>", "\n");



                Regex contentregex = new Regex(@"<P style=""TEXT-ALIGN: center"">(?<content>[0-9a-zA-Z\Wㄱ-힣\s]*)</P>");
                Regex re = new Regex(@">(?<ccc>[ㄱ-힣\s\W0-9]+)<");
                subcontent = html.Substring(html.IndexOf(@"<div class=""tx-content-container"">"), html.IndexOf(@"<div class=""clr_ns clearfix"">") - html.IndexOf(@"<div class=""tx-content-container"">"));
                mc = re.Matches(subcontent);
                content = new string[mc.Count];
                idx = 0;

                foreach (Match m in mc)
                {
                    content[idx++] = m.Groups["ccc"].ToString();
                    Console.WriteLine(content[idx - 1]);
                }

                Recipe recipe = new Recipe(sort, group, time, difficulty, ingredient, sauce, content, -1);
                recipe.ShowDialog();
            }

            myConn.Close();
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            makeRecipe recipe = new makeRecipe(m_id);
            recipe.ShowDialog();

        }

        private void listBox_wrotenList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_wrotenList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadDB();
            string t = listBox_wrotenList.SelectedItem.ToString();
            string url;
            string[] cc = { "" };

            MySqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new MySqlDataAdapter("SELECT *FROM makerecipe WHERE title = '" + t + "'", myConn);
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cc[0] = row["content"].ToString();
                Recipe recipe = new Recipe(row["category"].ToString(), "", row["cooktime"].ToString(), row["difficulty"].ToString(), row["ingredient"].ToString(), row["sauce"].ToString(), cc, -1);
                recipe.ShowDialog();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            makelistRefresh();
            cliplistRefresh();
        }
    }
}
