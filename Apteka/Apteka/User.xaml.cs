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
using System.Windows.Shapes;

namespace Apteka
{
    /// <summary>
    /// Logika interakcji dla klasy User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            //logika dla listboxa - pokazanie artykułów z koszyka
        }

        private void ViewClick(object sender, RoutedEventArgs e)
        {
            //logika dla listboxa2 - pokazanie zamówień złożonych przez klienta
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            //dodaj do koszyka
        }
    }
}
