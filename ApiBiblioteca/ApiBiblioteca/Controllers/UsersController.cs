using ApiBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using ApiBiblioteca.DataBase;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ApiBiblioteca.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route ("listar")]

        public dynamic listarCliente()
        {

            Conexion conexion = new Conexion();

            var data = conexion.EstablecerConexion();

            MySqlDataReader reader = null;

            string sql = "SELECT * FROM users ";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, data);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string nombre = reader.GetString(3);
                        string edad = reader.GetString(4);

                    }
                }
                else
                {
                    return "No se encontro registro";
                }
            }
            catch (MySqlException ex)
            {
                

            }

            //List<User> users = new List<User>
            //{

            //    new User
            //    {
            //        Id = 1,
            //        nombre = "leonardo",
            //        edad = 24
            //    },

            //        new User
            //    {
            //        Id = 1,
            //        nombre = "aya",
            //        edad = 24
            //    }

            //};

            return data;

        }
    }
}
