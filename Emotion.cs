using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using ChatBot;

namespace Regression
{
    public partial class Emotion : Form
    {
        public Emotion()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void Emotion_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -3;     // -10...10
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            String str = "Hai Welcome to our ChatBot...Please enter How was your Mood Today ?";
            synthesizer.Speak(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            player.SoundLocation = Application.StartupPath + "//Song//Journey.wav";
            player.Play();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            player.SoundLocation = Application.StartupPath + "//Song//Sad.wav";
            player.Play();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            player.SoundLocation = Application.StartupPath + "//Song//bored.wav";
            player.Play();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            player.SoundLocation = Application.StartupPath + "//Song//romantic.wav";
            player.Play();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Stop();
            botcheck1 obj = new botcheck1();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
