using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Persistencia
{
    internal class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {

            try
            {
                MySqlConnection conn;
                string myConnectionString;

                myConnectionString = "server=localhost;uid=usuarioApp;pwd=usuarioApp1234;database=miprimerdatabase";
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conextarce a la base");
                return null;
            }
        }
    }
}
