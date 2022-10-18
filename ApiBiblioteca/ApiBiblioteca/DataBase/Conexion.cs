using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ApiBiblioteca.DataBase
{
    public class Conexion
    {

        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "biblioteca";
        static string user = "root";
        static string pass = "1234";
        static string port = "3306";

        string cadenaConexion = "Server=" + servidor + ";" + "Database=" + db + ";" + "Uid=" + user + ";" + "Pwd=" + pass + ";";

        public MySqlConnection EstablecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
                return conex;
        }

        //MySqlConnection cnt;

        //cnt = new MySqlConnection("Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");
        //MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
        //sb.Server = "localhost";
        //    sb.UserID = "root";
        //    sb.Password = "";
        //    sb.Database = "biblioteca";
        //    cnt = new MySqlConnection(sb.ConnectionString);

        //    try
        //    {
        //        cnt.Open();
        //        MessageBox.Show("conectado");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
    }
}
