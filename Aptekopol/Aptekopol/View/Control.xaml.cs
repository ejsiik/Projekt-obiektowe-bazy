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

namespace Aptekopol.View
{
    /// <summary>
    /// Logika interakcji dla klasy Control.xaml
    /// </summary>
    public partial class Control : UserControl
    {
        public static Brush MalowanieWszystkich { get; set; }
        public Control()
        {
            InitializeComponent();
        }

        public void error(string errorText)
        {
            Pole_text_narzędzia.Text = errorText;
            if (errorText != "")
            {
                Obramowanie.BorderThickness = new Thickness(1);
                Narzędzia.Visibility = Visibility.Visible;
            }
            else
            {
                Obramowanie.BorderThickness = new Thickness(0);
                Narzędzia.Visibility = Visibility.Hidden;
            }
        }
       
        
        public string text
         {
              get { return Pole_text.Text; }
              set { Pole_text.Text = value; }
         }
        public Brush Malowanie
        {
             get { return Obramowanie.BorderBrush; }
             set { Obramowanie.BorderBrush = value; }
        }
         
    }
}
