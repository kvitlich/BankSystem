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

namespace BankSystem_C
{
    /// <summary>
    /// Interaction logic for AunteficationPage.xaml
    /// </summary>
    /// 
    
    public partial class AunteficationPage : Page
    {
        public AunteficationPage()
        {
            InitializeComponent();
          
        }

        private void ByIIN(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("EnterByIIN.xaml", UriKind.Relative));
            //this.NavigationService.Navigate("pack://application:,,,/EnterByIIN.xaml");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
