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

namespace Aptekopol.View
{
    /// <summary>
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Client.IsChecked == true)
            {
                Client client = new Client();
                client.Show();
            }
            else if (Manager.IsChecked == true)
            {
                Manager manager = new Manager();
                manager.Show();
            }
            else if (Worker.IsChecked == true)
            {
                Worker worker = new Worker();
                worker.Show();
            }
            else if (Regional_manager.IsChecked == true)
            {
                MainWindow regional_manager = new MainWindow();
                regional_manager.Show();
            }
        }
    }
}
