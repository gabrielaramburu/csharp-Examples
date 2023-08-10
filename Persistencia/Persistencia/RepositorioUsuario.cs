using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using MySql.Data;


namespace Persistencia
{
    public class RepositorioUsuario
    {
        public ArrayList obtenerUsuarios()
        {
            ArrayList usuarios = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM usuarios;";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string login = resultado.GetString(1);
                    string pass = resultado.GetString(2);
                    usuarios.Add(new UsuarioVO(id, login, pass));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conextarce a la base");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                
            }
            Console.WriteLine("Fin ejecución obtener usuario");
            return usuarios;
        }

    }
}