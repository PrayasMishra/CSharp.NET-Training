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

namespace Capgemini.Wpf.Day1
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtBxFirstname.Clear();
            TxtBxLastname.Clear();
            TxtBxPassword.Clear();
            TxtBxPhoneNo.Clear();
            TxtBxCity.Clear();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
