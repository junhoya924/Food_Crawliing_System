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
    public partial class SearchPage : Form
    {
        string m_searchData;
        int m_difficulty = 0;
        int m_cookingTime = 0;
        string[] urlarr = null;
        string sort, group, time, difficulty, ingredient, sauce;
        string[] content = null;
        string m_id;
        string clipurl;
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
        public SearchPage()
        {
            InitializeComponent();
        }

        public SearchPage(string searchData, int time, int difficulty, string _id)
        {
            InitializeComponent();
            m_searchData = searchData;
            m_cookingTime = time;
            m_difficulty = difficulty;
            gettitle(m_searchData, 1, m_difficulty, m_cookingTime);
            m_id = _id;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            gettitle(m_searchData, 1, m_difficulty, m_cookingTime);
        }

        private void listBox_searchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_searchList.SelectedItem == null)
                return;
        }



        public void gettitle(string search, int pagenum, int difficulty, int cookingtime)
        {
            urlarr = null;
            listBox_searchList.Items.Clear();
            string bod = "<div class=\"collWid collTot\">";
            char[] de = bod.ToCharArray();

            string[] arrPattern = null;
           
            string url = "http://cook.miznet.daum.net/search/search.do?t=recipe&q=" + search + "&pageNo=" + pagenum.ToString() + 
                "&difficulty=" + difficulty.ToString() + "&cookingtime=" + cookingtime.ToString();
            WebClient w = new WebClient();
            w.Encoding = Encoding.UTF8;
            string html = w.DownloadString(url);
            string htmlen = HttpUtility.UrlDecode(html, Encoding.UTF8);
            url = HttpUtility.UrlEncode(url, Encoding.Unicode);
            //url = HttpUtility.UrlDecode(url, Encoding.UTF8);

            Regex regex1 = new Regex(@"target=""_blank"" class=""stit fl"">(?<title>[0-9A-Za-z\Wㄱ-힣\s]*)<span");
            MatchCollection mc = regex1.Matches(html);
            int idx = 0;
            arrPattern = new string[mc.Count];

            foreach (Match m in mc)
            {
                arrPattern[idx++] = m.Groups["title"].ToString();
            }

            for (int i = 0; i < arrPattern.Length; i++)
            {
                arrPattern[i] = arrPattern[i].Replace("<b>", "");
                arrPattern[i] = arrPattern[i].Replace("</b>", "");
                arrPattern[i] = arrPattern[i].Replace("</a>", "");
                arrPattern[i] = arrPattern[i].Replace("\t", "");
                arrPattern[i] = arrPattern[i].Replace("\r", "");
                arrPattern[i] = arrPattern[i].Replace("\n", "");
                arrPattern[i] = arrPattern[i].Replace("&#65279;", "");
                arrPattern[i] = arrPattern[i].Replace("<em class=\"recommend fl\">추천</em>", "");

            }

            Regex regex2 = new Regex(@"<p class=""tit"">\s*<a href=""(?<url>[a-zA-Z0-9\W]*)"" target=""_blank");
            MatchCollection mc2 = regex2.Matches(html);
            idx = 0;
            urlarr = new string[mc2.Count];

            foreach (Match m in mc2)
            {
                urlarr[idx++] = m.Groups["url"].ToString();
            }

            for (int i = 0; i < arrPattern.Length; i++)
            {
                listBox_searchList.Items.Add(arrPattern[i].ToString());
            }

            downloadtitlepic(html);

        }

        private void downloadtitlepic(string _html)
        {
            string[] picurl = null;
            string str = "";
            int idx = 0;
            WebClient client = new WebClient();
            Regex regex = new Regex(@"img src=""(?<url>[a-zA-Z0-9\W]*)"" alt=");
            MatchCollection mc = regex.Matches(_html);

            picurl = new string[mc.Count];

            foreach (Match m in mc)
            {
                picurl[idx++] = m.Groups["url"].ToString();
            }

            for (int i = 0; i < picurl.Length; i++)
            {
                str = "D:\\DPCR\\" + (i + 1).ToString() + ".jpg";
           
                client.DownloadFile(new Uri(picurl[i]), str);
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_searchData = search_TextBox.Text;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            m_difficulty = 3;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            m_cookingTime = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            m_cookingTime= 1;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            m_cookingTime = 2;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            m_cookingTime = 3;
        }

        private void button_clip_Click(object sender, EventArgs e)
        {
            loadDB();

            clipurl = urlarr[listBox_searchList.SelectedIndex];

            string temp = "INSERT INTO `scrabrecipe` (`recipeurl`, `userid` , `title`) VALUES ('" + clipurl + "', '" + m_id + "', '" + listBox_searchList.SelectedItem.ToString() + "')";
            MySqlCommand mc = new MySqlCommand(temp, myConn);
            mc.ExecuteReader();

            myConn.Close();
            MessageBox.Show("clip complete");
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getcontent(string url)
        {
            sort = null;
            group = null;
            time = null;
            difficulty = null;
            ingredient = null;
            sauce = null;
            content = null;
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
        }

        private void listBox_searchList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_searchList.SelectedItem == null)
                return;
            int selectedIndex = listBox_searchList.SelectedIndex;
            getcontent(urlarr[selectedIndex]);
            Recipe recipe = new Recipe(sort, group, time, difficulty, ingredient, sauce, content, selectedIndex+1);
            recipe.ShowDialog();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
