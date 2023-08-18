using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using MySql.Data;


namespace Persistencia
{
    public class RepositorioArticulo
    {


        public void asignarArticuloAPaquete(int idPaquete, int idArticulo)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE miprimerdatabase.articulos set idPaquete =  @idPaquete where id = @idArticulo";
                consultaSql.Parameters.AddWithValue("?idPaquete", idPaquete);
                consultaSql.Parameters.AddWithValue("?idArticulo", idArticulo);
                consultaSql.Connection = conn;
                int cantRegistrosModificados = consultaSql.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conextarce a la base" + e.ToString);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
            Console.WriteLine("Fin ejecución quitar articulos del paquete");

        }

        public ArrayList obtenerArticulosSinPaquete()
        {
            ArrayList articulos = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM articulos where idPaquete is null";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string desc = resultado.GetString(1);
                    int precio = resultado.GetInt32(2);
                    articulos.Add(new ArticuloVO(id, desc, precio));
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
            Console.WriteLine("Fin ejecución obtener articulos sin paquete");
            return articulos;
        }

        public ArrayList obtenerArticulosPorPaquete(int idPaquete)
        {
            ArrayList articulos = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM articulos WHERE idPaquete = @id";

                consultaSql.Parameters.AddWithValue("?id", idPaquete);
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string desc = resultado.GetString(1);
                    int precio = resultado.GetInt32(2);
                    articulos.Add(new ArticuloVO(id, desc, precio));
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
            Console.WriteLine("Fin ejecución obtener articulos sin paquete");
            return articulos;
        }
    }
}