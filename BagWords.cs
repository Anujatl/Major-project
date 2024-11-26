using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Regression
{
    public partial class BagWords : Form
    {
        Dictionary<string, int> wordFrequencyDictionary;

        List<TrainItem> trainingDataSet;
        string[] files;

        //   private KMeans objKMeans;
        private BackgroundWorker objBackgroundWorker;
        public BagWords()
        {
            InitializeComponent();
        }

        private void btnLoadTrainingSet_Click(object sender, EventArgs e)
        {
            trainingDataSet = new List<TrainItem>();
            //foreach (string file in files)
            //{
            string file = Application.StartupPath + Dataprocess.c1;
            string fileContent = File.ReadAllText(file);
            string processedFile = "";
            //if (checkBox1.Checked)
            //    processedFile = Regex.Replace(fileContent, "[^a-zA-Z ]", "");
            //else
            processedFile = fileContent;

            trainingDataSet.Add(new TrainItem() { FilePath = file, InputVector = null, Text = processedFile });

            //}

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = trainingDataSet.Count;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            txtFile.Text = trainingDataSet[(int)numericUpDown1.Value - 1].Text;
        }

        private void btnWord2Vec_Click(object sender, EventArgs e)
        {
            wordFrequencyDictionary = new Dictionary<string, int>();

            foreach (TrainItem item in trainingDataSet)
            {
                string[] words = item.Text.Split(' ');
                foreach (string word in words)
                {
                    string wordLowerCaps = word.ToLower();
                    if (wordFrequencyDictionary.ContainsKey(wordLowerCaps))
                    {
                        wordFrequencyDictionary[wordLowerCaps] += 1;
                    }
                    else
                    {
                        wordFrequencyDictionary[wordLowerCaps] = 1;
                    }
                }
            }

            wordFrequencyDictionary = (from entry in wordFrequencyDictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

            lblWords.Text = "Words: " + wordFrequencyDictionary.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWords frmWords = new frmWords(wordFrequencyDictionary);

            frmWords.OnApplyChanges += FrmWords_OnApplyChanges;
            frmWords.Show();
        }
        private void FrmWords_OnApplyChanges(object sender, Dictionary<string, int> e)
        {
            wordFrequencyDictionary = e;

            lblWords.Text = "Words: " + wordFrequencyDictionary.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
