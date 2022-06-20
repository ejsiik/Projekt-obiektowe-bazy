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
        public string login;
        public string password;
        public LoginWindow()
        {
            InitializeComponent();
        }
        private bool isEmpty(Control kt)
        {
            if (kt.text.Trim() == "")
            {
                kt.error("Pole nie może być puste!");
                return false;
            }
            kt.error("");
            return true;
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

            try
            {
                login = Place_Login.ToString();
                password = Place_Password.ToString();
                if (Manager.IsChecked == false && Client.IsChecked == false && Worker.IsChecked == false && Regional_manager.IsChecked == false)
                {
                    MessageBox.Show("Wybierz role");
                }
                else
                {
                    if (isEmpty(Place_Login) & isEmpty(Place_Password))
                    {
                        Place_Login.text = "";
                        Place_Password.text = "";
                    }
                }
                 
              
            }
            catch
            {
                MessageBox.Show("Podano błędne dane");
            }
        }

    }

}
