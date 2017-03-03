using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WF_DataBase
{
    class Create_db
    {
        private MySqlConnection connection;
        private string server;
        private string database = @"hello";
        private string uid;
        private string password;

        //constructor
        public Create_db(){
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            uid = "root";
            password = "Region02";
            string connectionString;
            connectionString = "SERVER="
                    + server + ";"
                    + "UID=" + uid + ";"
                    + "PASSWORD=" + password
                    + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        //Create dataBase
        public void create_db() 
        {
            MySqlCommand cmd;
            string command;
                if(this.OpenConnection() == true)
                {
                    command = "CREATE DATABASE IF NOT EXISTS `" + database + "` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;";
                    cmd = new MySqlCommand(command, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
        }
    }
}
