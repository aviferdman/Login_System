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
    /// Interaction logic for AdminMode.xaml
    /// </summary>
    public partial class AdminMode : Window
    {

        AdminModeDataContext AMDC;
        Interface myInterface = new Interface();

        public AdminMode()
        {
            InitializeComponent();
            AMDC = new AdminModeDataContext();
            this.DataContext = this.AMDC;

        }

        private void RemoveUserButton_Click(object sender, RoutedEventArgs e)
        {
            myInterface.removeUser(AMDC.RemoveUser);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
