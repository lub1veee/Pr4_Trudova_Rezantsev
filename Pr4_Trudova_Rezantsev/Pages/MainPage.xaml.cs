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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        { 
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Formula1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Formula1Page());
        }

        private void Button_Formula2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Formula2Page());
        }

        private void Button_Formula3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Formula3Page());
        }
    }
}
