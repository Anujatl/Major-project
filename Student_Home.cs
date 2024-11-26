using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Regression;

namespace ChatBot
{
    public partial class Student_Home : Form
    {
        BaseConnection con = new BaseConnection();
        public Student_Home()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            Startup obj = new Startup();
            obj.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Emotion obj = new Emotion();
            obj.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
