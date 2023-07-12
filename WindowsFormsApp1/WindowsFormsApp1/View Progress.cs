using LiveCharts.Wpf;
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

namespace WindowsFormsApp1
{
    public partial class View_Progress : Form
    {
        public View_Progress()
        {
            InitializeComponent();
            chart1.MouseClick += Chart1_MouseClick;
        }
        private void Chart1_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint dataPoint = chart1.Series[result.Series.Name].Points[result.PointIndex];
                double xValue = dataPoint.XValue;
                double yValue = dataPoint.YValues[0]; // Assuming a single Y value
                MessageBox.Show($"Clicked point: X = {xValue}, Y = {yValue}");
            }
        }
        private void View_Progress_Load(object sender, EventArgs e)
        {
            int min = -10;
            int max = 10;
            double[] coeff = { 0.7, -15.75, 3 };

            ChartArea area = new ChartArea();
            area.AxisX.Minimum = min;
            area.AxisX.Maximum = max;
            area.AxisY.Minimum = min;
            area.AxisY.Maximum = max;
            chart1.ChartAreas.Add(area);

            System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series();
            ser.ChartType = SeriesChartType.Line;
            ser.Color = Color.Red;
            ser.BorderWidth = 2;

            for(int x = min; x <= max; x++)
            {
                double y = EvaluatePolynomial(coeff,x);
                ser.Points.AddXY(x,y);
            }

            chart1.Series.Add(ser);
        }

        private double EvaluatePolynomial(double[] coefficients, double x)
        {
            double y = 0;
            for(int i = 0; i < coefficients.Length; i++)
            {
                y += coefficients[i] * Math.Pow(x,i);
            }
            return y;
        }


    }
}
