using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TSP_2
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Start_Button_Click(object sender, EventArgs e)
        {
            int mean = 0;

            for (int i = 0; i < Convert.ToInt32(NumberOFExperimentsTextBox.Text); i++)
            {
                var result = new Simulation().Simulate(Convert.ToDouble(lyambdaTextBox.Text), Convert.ToDouble(timeTextBox.Text));

                var a = result.GetEnumerator();
                mean += result.Count;

                for (int j = 0; j < result.Count; j++)
                {
                    chart1.Series[0].Points.AddXY(a.Current.time, Convert.ToDouble(a.Current.N)); // делать по одному или возрастающий график не принципиален (так удобнее воспринимать)?
                    TimeNRichTextBox.AppendText($"{a.Current.time.ToString()} - {a.Current.N.ToString()}\n");
                    a.MoveNext();
                }
            }
            MeanTextBox.Text = (mean / Convert.ToDouble(NumberOFExperimentsTextBox.Text)).ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            TimeNRichTextBox.Clear();
            MeanTextBox.Clear();
        }
    }
}