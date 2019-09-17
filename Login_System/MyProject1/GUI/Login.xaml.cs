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
using MyProject1.Buisness;

namespace MyProject1.GUI
{
    /// <summary>
    /// Interaction logic for Loginxaml.xaml
    /// </summary>
    public partial class Login : Window
    {
        LoginDataContext LDC;
        Interface myInterface = new Interface();

        public Login()
        {
            InitializeComponent();
            LDC = new LoginDataContext();
            this.DataContext = this.LDC;
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (myInterface.login(LDC.UserName, LDC.Password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
            
        }

        private void AdminAccessButton_Click(object sender, RoutedEventArgs e)
        {
            if (myInterface.login(LDC.UserName, LDC.Password))
            {
                AdminMode adminMode = new AdminMode();
                adminMode.Show();
                this.Close();
            }
            else
            {

            }
        }
    }
}
