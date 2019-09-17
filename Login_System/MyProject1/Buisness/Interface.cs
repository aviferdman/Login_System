using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Buisness
{
    public class Interface
    {
        private TasksManager taskManager = new TasksManager();

        public bool login(String userName, String password)
        {
            return taskManager.login(userName, password);
        }

        public bool register(String userName, String password)
        {
            return taskManager.register(userName, password);
        }

        public bool removeUser (string userName)
        {
            return taskManager.removeUser(userName);
        }
    }
}
