using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Data
{
    class UserD
    {
        String userName;
        String password;

        public UserD (String userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }

        public String getUserName()
        {
            return userName;
        }
        public void setUserName(String userName)
        {
            this.userName = userName;
        }
        public String getPassword()
        {
            return password;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
    }
}
