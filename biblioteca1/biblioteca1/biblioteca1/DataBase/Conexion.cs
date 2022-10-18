using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca1.DataBase
{
     class Conexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "biblioteca";
        static string user = "root";
        static string pass = "123";
        static string port = "3306";

        string cadenaConexion = "Server=" + servidor + ";" + "Database=" + db + ";" + "Uid=" + user + ";" + "Pwd=" + pass + ";";

        public MySqlConnection EstablecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                App.Current.MainPage.DisplayAlert("Info", "guardado", "OK");
            }
            catch (MySqlException ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            return conex;
        }
    }
}
