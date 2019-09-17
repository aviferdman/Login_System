using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.GUI
{
    class AdminModeDataContext
    {
        String removeUser;
        public String RemoveUser
        {
            get
            {
                return removeUser;
            }
            set
            {
                removeUser = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("RemoveUser"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
