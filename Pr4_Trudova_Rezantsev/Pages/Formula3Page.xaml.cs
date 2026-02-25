using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pr4_Trudova_Rezantsev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Formula3Page.xaml
    /// </summary>
    public partial class Formula3Page : Page
    {
        Series currentSeries = new Series("y = 0.0025·1·x³ + √x + e⁰·⁸²");

        public Formula3Page()
        {
            InitializeComponent();

            double b = 1;

            Function = x => 0.0025 * b * Math.Pow(x, 3) + Math.Sqrt(x) + Math.Exp(0.82);

            ChartArea chartArea = new ChartArea("Main");

            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(50, 128, 128, 128);
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(50, 128, 128, 128);

            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "Y";

            chartArea.AxisX.Interval = 1;

            FuncGraph.ChartAreas.Add(chartArea);

            currentSeries.ChartType = SeriesChartType.Line;
            currentSeries.BorderWidth = 2;
            currentSeries.Color = System.Drawing.Color.Blue;
            currentSeries.IsValueShownAsLabel = false;

            FuncGraph.Series.Add(currentSeries);

            DrawGraph();
        }

        private Func<double, double> Function;

        private void ButtonClear(object sender, RoutedEventArgs e)
        {
            currentSeries.Points.Clear();
        }

        private void ButtonCount(object sender, RoutedEventArgs e)
        {
            DrawGraph();
            if (string.IsNullOrEmpty(xBox.Text)) return;
            if(!double.TryParse(xBox.Text, out double x)) return;
            ResultBox.Text = Function(x).ToString();
        }

        private void DrawGraph()
        {
            currentSeries.Points.Clear();

            double step = 0.05;

            for (double x = 0; x <= 10; x += step)
            {
                double y = Function(x);

                if (!double.IsInfinity(y) && !double.IsNaN(y))
                {
                    currentSeries.Points.AddXY(Math.Round(x, 2), Math.Round(y, 3));
                }
            }
        }
    }
}