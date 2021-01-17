using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JeanaiRoberts_CE02
{
    public class DBUtilities
    {
        public static string BuildConnectionString()
        {
            string serverIP = "";
            string port = "";

            try
            {
                // open the text file using a streamreader
                using (StreamReader sr = new StreamReader("C:\\VFW\\connect.txt"))
                {
                    // read the server ip data
                    serverIP = sr.ReadLine();
                    port = sr.ReadLine();

                }
            }
            catch (Exception e)
            {
                // display the exception
                MessageBox.Show(e.ToString());
            }

            // return the entire string
            return $"server=192.168.1.75;uid=dbsAdmin;pwd=password;database=Series;SslMode=none;port={port};";
        }

        public static MySqlConnection Connect(string myConnectionString)
        {
            MySqlConnection conn = new MySqlConnection();
            // inside here is where we will try to connect to the database
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                MessageBox.Show("Connected");

                return conn;
            }
            catch (MySqlException e)
            {
                // create string variable to hold the output message
                string msg;

                // check what exception was recieved an d based on the number we will do a switch
                switch (e.Number)
                {
                    case 0:
                        msg = e.ToString();
                        break;
                    case 1042:
                        msg = "Can't resolve host address.\n" + myConnectionString; // will display what part of the connection string is the issue
                        break;
                    case 1045:
                        msg = "Invalid username/password";
                        break;
                    default:
                        // generic messgae if the others do not cover it
                        msg = e.ToString() + "\n" + myConnectionString;
                        break;
                }

                MessageBox.Show(msg);

                conn = null;
                return conn;
            }


        }
    }
}
