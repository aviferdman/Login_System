using MyProject1.Buisness;
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

namespace MyProject1.GUI
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        RegisterDataContext RDC;
        Interface myInterface = new Interface();

        public Register()
        {
            InitializeComponent();
            RDC = new RegisterDataContext();
            this.DataContext = this.RDC;
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            if (RDC.Password.ToString().Equals(RDC.RePassword.ToString()))
            {
                if (myInterface.register(RDC.UserName, RDC.Password))
                {
                    Login login = new Login();
                    login.Show();
                    this.Close();   
                }
                else
                {
                    
                }
            }

            else
            {
                MessageBox.Show("the passwords are different");
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RePassword_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RePassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
