using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Data
{
    class UserData
    {
        public static string database_name = "MyDatabase.sqlite";
        public static SQLiteCommand command;
        public static string connetion_string = $"Data Source={database_name};Version=3;";
        public static SQLiteConnection connection = new SQLiteConnection(connetion_string);
        public static SQLiteDataReader dataReader;

        public static Boolean save(string userName, string password)
        {
            if (existUser(userName, password))
            {
                return updateUser(userName, password);
            }
            else
            {
                return saveNewUser(userName, password);
            }
        }

        public static UserD open(string userName)
        {
            UserD userD = null;

            try
            {
                connection.Open();

                string sql = "select * from UserTable WHERE UserName ='" + userName + "'";
                command = new SQLiteCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    string password = (string)dataReader.GetValue(1);
                    userD = new UserD(userName, password);
                }
                dataReader.Close();
                command.Dispose();
                return userD;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool saveNewUser(string userName, string password)
        {
            try
            {
                connection.Open();
                command = new SQLiteCommand(null, connection);
                command.CommandText =
                    "INSERT INTO UserTable (UserName,Password) " +
                    "VALUES (@UserName, @Password)";
                SQLiteParameter UserName_param = new SQLiteParameter(@"UserName", userName);
                SQLiteParameter Password_param = new SQLiteParameter(@"Password", password);

                command.Parameters.Add(UserName_param);
                command.Parameters.Add(Password_param);

                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                connection.Close();
            }
        }

        public static bool updateUser(string userName, string password)
        {
            try
            {
                connection.Open();
                command = new SQLiteCommand(null, connection);
                command.CommandText =
                    "UPDATE UserTable set Password = @Password WHERE UserName ='" + userName + "'";
                SQLiteParameter Password_param = new SQLiteParameter(@"Password", password);
                command.Parameters.Add(Password_param);

                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                connection.Close();
            }
        }

        public static bool existUser(string userName, string password)
        {
            try
            {
                connection.Open();
                string sql = "select UserName from UserTable WHERE UserName = '" + userName + "'";
                command = new SQLiteCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    dataReader.Close();
                    return true;
                }
                dataReader.Close();
                return false;
            }

            catch (Exception)
            {
                return false;

            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        public static bool removeUser (String userName)
        {
            try
            {
                connection.Open();
                string sql = "DELETE FROM UserTable WHERE UserName='" + userName + "'";
                command = new SQLiteCommand(sql, connection);
                using (command)
                {
                    command.Prepare();
                    command.ExecuteNonQuery();
                    command.Dispose();
                    return true;

                }
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
