using ChatBot;
using Regression.Linear;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regression
{
    public partial class botcheck1 : Form
    {
        BaseConnection con = new BaseConnection();
        public static string ans = "";
        public botcheck1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {    

            string ss = test(textBox2.Text);
            string query = "";


            richTextBox1.AppendText("\n");
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText("QUESTIONS: "+textBox2.Text+" \n");
            int len = ss.Length;
            if (len < 4)
            {
                query = "select answer from bot1 where question ='" + ss + "'";
            }
            else
            {
                query = "select answer from bot1 where (question LIKE '%' +'" + ss + "' +'%')";
            }

           
            SqlDataReader dr = con.ret_dr(query);
            if (dr.Read())
            {
                ans= dr[0].ToString();
            }
            pictureBox1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.AppendText("BOTS Says: "+ans+"\n");
           
            textBox2.Text = "";
        }
        public static string test(string text)
        {
            // Replace any character that is not a letter, digit, space, underscore, or hyphen with an empty string
            return Regex.Replace(text, "[^0-9A-Za-z _-]", "");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -3;    // -10...10

            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Speak(ans);
            pictureBox1.Visible = false;
        }

        private void botcheck1_Load(object sender, EventArgs e)
        {
            //Program.uname = "mahesh123";
            string name = "";
            string query1 = "select name from User_details where username='"+Program.uname+"'";
            SqlDataReader dr = con.ret_dr(query1);
            if (dr.Read())
            {
               name = dr[0].ToString();
            }
            string data = "Hai " + name+ " I am a chatbot. I can try and answer some of your questions ? How can i help you";
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -3;    // -10...10

            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Speak(data);
            pictureBox1.Visible = false;
            richTextBox1.AppendText(data+"\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
