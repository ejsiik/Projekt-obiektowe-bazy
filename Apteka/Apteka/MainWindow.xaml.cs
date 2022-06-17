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

namespace Apteka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //koment
        }
        private void confirmClick(object sender, RoutedEventArgs e)
        {
            if (Empleyee.IsChecked == false && Client.IsChecked == false)
            {
                System.Windows.MessageBox.Show("Zaznacz opcje");
            }
            else if (Empleyee.IsChecked == true)
            {

            }
            else if (Client.IsChecked == true)
            {

            }
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
