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
    /// Логика взаимодействия для Formula2Page.xaml
    /// </summary>
    public partial class Formula2Page : Page
    {

        public Func<double, double> Fx;
        public Formula2Page()
        {
            InitializeComponent();
        }

        private void ButtonCount(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClear(object sender, RoutedEventArgs e)
        {

        }

        private string CountResult(double fx)
        {
            ResultBox.Text = Formuler.CalculateFormul2(Fx, Formuler.ParseString(xBox.Text, pBox.Text));
        }

        public double GetF() => 0;

        private void RbSh(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(xBox.Text, out double x)) return;
            Fx = g => Math.Sinh(g);
        }

        private void RbX2(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(xBox.Text, out double x)) return;
            Fx = g => Math.Pow(g, 2);
        }

        private void RbEx(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(xBox.Text, out double x)) return;
            Fx = g => Math.Pow(Math.E, g);
        }
    }
}
