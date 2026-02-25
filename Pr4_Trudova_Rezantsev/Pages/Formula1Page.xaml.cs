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

namespace Pr4_Trudova_Rezantsev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Formula1Page.xaml
    /// </summary>
    public partial class Formula1Page : Page
    {
        public Formula1Page()
        {
            InitializeComponent();
        }

        private void ButtonCount(object sender, RoutedEventArgs e)
        {
            double[] points = Formuler.ParseString(xBox.Text, yBox.Text, zBox.Text);
            foreach (double point in points)
            {
                Console.WriteLine(point);
            }
            if (points?.Length != 3) return;
            double result = Formuler.CalculateFormul1(points[0], points[1], points[2]);
            ResultBox.Text = result.ToString();
        }

        private void ButtonClear(object sender, RoutedEventArgs e)
        {
            xBox.Text = "";
            yBox.Text = "";
            zBox.Text = "";
            ResultBox.Text = "";
        }
    }
}
