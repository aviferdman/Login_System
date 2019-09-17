using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.GUI
{
    class LoginDataContext
    {
        String userName;
        public String UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        String password;
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
