using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using Regression.Linear;

namespace ChatBot
{
    public partial class botcheck : Form
    {
        static Regression.Linear.ChatBot bot;
        public static string outtt = "";
     //   BaseConnection con = new BaseConnection();
        public botcheck()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bot = new Regression.Linear.ChatBot();
            outtt = bot.getOutput(textBox2.Text);
            pictureBox1.Visible = true;
            backgroundWorker1.RunWorkerAsync();

            
           // backgroundWorker1.Dispose();
            textBox1.Text = outtt;
         
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -3;    // -10...10
          
            synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Adult);
            synthesizer.Speak(outtt);
            pictureBox1.Visible = false;
        }
    }
}
