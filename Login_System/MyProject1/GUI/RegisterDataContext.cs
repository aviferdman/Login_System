using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.GUI
{
    class RegisterDataContext
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

        String rePassword;
        public String RePassword
        {
            get
            {
                return rePassword;
            }
            set
            {
                rePassword = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("RePassword"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
