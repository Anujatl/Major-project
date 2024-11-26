using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using com.sun.org.apache.xpath.@internal.operations;
using weka.gui;
using System.Text.RegularExpressions;

namespace ChatBot
{
    public partial class aimlwriter : Form
    {
        BaseConnection con = new BaseConnection();
        public static string sid = "";
        public aimlwriter()
        {
            InitializeComponent();
            aimlreader();
        }

        public void aimlreader()
        {
            string text;
            var fileStream = new FileStream(Application.StartupPath+"\\aiml\\mental.aiml", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            richTextBox1.Text = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        public string getid()
        {
           
                string query = "select isnull(max(qid),1)+1 from bot1";
                SqlDataReader dr = con.ret_dr(query);
                if (dr.Read())
                {
                    sid = dr[0].ToString();
                   
                }
            return sid;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tag = "<category><pattern>" + textBox2.Text + "</pattern><template>" + textBox1.Text + "</template></category>";
            richTextBox2.Text = tag;
            string id = getid();
            string qdata = test(textBox2.Text);
            string adata = test(textBox1.Text);
            string query1 = "insert into bot1 values(" + id + ",('" + qdata + "'),('" + adata + "'))";
            if (con.exec1(query1) > 0)
            {
                //MessageBox.Show("User details Registered Successfully...");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Data Syntax Error");
            }
        }
        public static string test(string text)
        {
            // Replace any character that is not a letter, digit, space, underscore, or hyphen with an empty string
            return Regex.Replace(text, "[^0-9A-Za-z _-]", "");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] contents=richTextBox1.Text.Split(new string[] { "<aiml>" }, StringSplitOptions.None);
            richTextBox3.Text = contents[0].ToString() + "<aiml>" + richTextBox2.Text + contents[1].ToString();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Application.StartupPath + "\\aiml\\mental.aiml",false))
            {
                file.WriteLine(richTextBox3.Text);
            }
            aimlreader();
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
        }
    }
}
