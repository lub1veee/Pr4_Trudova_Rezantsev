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

        }

        private void ButtonClear(object sender, RoutedEventArgs e)
        {

        }

        private string CalculateFormul(double x, double y, double z)
        {
            if(x >= y || x == 0) return "Ошибка";
            return Math.Abs(Math.Pow(x,(y/x) - Math.)
        }
    }
}
