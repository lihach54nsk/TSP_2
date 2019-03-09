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
            chart1.Series[0].Points.Clear();
            var result = new Simulation().Simulate(Convert.ToDouble(lyambdaTextBox.Text), Convert.ToDouble(timeTextBox.Text));

            var a = result.GetEnumerator();

            for (int i = 0; i < result.Count; i++)
            {
                chart1.Series[0].Points.AddXY(a.Current.time, Convert.ToDouble(a.Current.N));
                a.MoveNext();
            }
        }
    }
}