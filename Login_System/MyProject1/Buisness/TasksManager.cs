using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject1.Data;

namespace MyProject1.Buisness
{
    class TasksManager
    {
        
        public bool login (String userName, String password)
        {
            if (isValidUserName(userName) & isValidPassword(password))
            {
                return UserData.existUser(userName, password); 
            }
            else
            {
                return false;
            }
        }

        public bool register (String userName, String password)
        {
            if (isValidUserName(userName) & isValidPassword(password))
            {
                return UserData.save(userName, password);
            }
            else
            {
                return false;
            }
        }

        public bool removeUser (String userName)
        {
            if (isValidUserName(userName))
            {
                return UserData.removeUser(userName);
            }
            else
            {
                return false;
            }
        }

        public static Boolean isValidUserName(String userName)
        {
            return true;
        }

        public static Boolean isValidPassword(String userName)
        {
            return true;
        }

    }
}
