using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeSolution.Database
{
    class Conexion
    {
        public static MySqlConnection Dbconexion()
        {
             string servidor = "localhost";
             string db = "biblioteca";
             string user = "root";
             string pass = "";
             string port = "3306";

            string cadenaConexion = "Server=" + servidor + ";" + "Database=" + db + ";" + "Uid=" + user + ";" + "Pwd=" + pass + ";";
            
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
             
                return conn;
            }
            catch (MySqlException ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                return null;
            }
        }
    }
}
