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
    /// Interaction logic for EnterByIIN.xaml
    /// </summary>
    public partial class EnterByIIN : Page
    {
        public EnterByIIN()
        {
            InitializeComponent();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            ActiveAccount activeAccount = new ActiveAccount();
            if (!activeAccount.EnterByIIN(iinTextBox.Text))
                MessageBox.Show("Вы ввели неверные данные!");
            else
               this.NavigationService.Navigate(new Uri("UserMainPage.xaml", UriKind.Relative));
        }
    }
}
