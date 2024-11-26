using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Regression.Linear;

namespace Regression
{
    public partial class AccuracyGraph : Form
    {
        public AccuracyGraph()
        {
            InitializeComponent();
            fillChart();
            fillChart2();
        }
        private void fillChart()
        {
            chart1.ChartAreas[0].AxisY.Minimum = 0.8;

            chart1.ChartAreas[0].AxisY.Maximum = 1;
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Accuracy"].Points.AddXY("SVM", Program.grapha1);
            chart1.Series["Accuracy"].Points.AddXY("TFIDF", Program.grapha4);

            //chart title  
            chart1.Titles.Add("Accuracy Chart");
        }
        private void fillChart2()
        {
            chart2.ChartAreas[0].AxisY.Minimum = 0.8;

            chart2.ChartAreas[0].AxisY.Maximum = 1;
            //AddXY value in chart1 in series named as Salary  
            chart2.Series["F1Score"].Points.AddXY("SVM", Program.graphf1);
            chart2.Series["F1Score"].Points.AddXY("TFIDF", Program.graphf4);

            //chart title  
            chart2.Titles.Add("F1Score Chart");
        }
    }
}
