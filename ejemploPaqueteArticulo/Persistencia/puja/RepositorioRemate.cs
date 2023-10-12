using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.puja
{
    public class RepositorioRemate
    {
        public ArrayList obtenerRemates()
        {
            ArrayList remates = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM remates where fechaLimitePuja > @fechaActual";
                consultaSql.Parameters.AddWithValue("?fechaActual", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string desc = resultado.GetString(1);

                    remates.Add(new RemateVO(id, desc));
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
            Console.WriteLine("Fin ejecución obtener remates");
            return remates;
        }



        public RemateVO obtenerRemate(int idRemate)
        {
            RemateVO remateObtenido = null;
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM remates where id = @id;";
                consultaSql.Parameters.AddWithValue("?id", idRemate);

                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                if (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string desc = resultado.GetString(1);
                    DateTime fechaPujaFinal = resultado.GetDateTime(2);
                    string usuarioPujaFinal = resultado.GetString(3);
                    int montoMaximoPujaFinal = resultado.GetInt32(4);
                    DateTime fechaLimitePuja = resultado.GetDateTime(5);
                    remateObtenido = new RemateVO(
                        id, desc, fechaPujaFinal,
                        usuarioPujaFinal, montoMaximoPujaFinal, fechaPujaFinal);
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
            return remateObtenido;
        }

        public int actualizoPuja(int idRemate, int monto, string usuario, 
            DateTime fechaUltimaPuja)
        {
            {
                MySqlConnection conn = null;
                try
                {
                    conn = Conexion.obtenerConexion();

                    MySqlCommand consultaSql = new MySqlCommand();

                    consultaSql.CommandText = "UPDATE  remates " +
                        "set fechaPujaFinal = @fechaActual, " +
                        "usuarioPujaFinal = @usuarioNuevaPuja, " +
                        "montoMaximoPujaFinal = @montoNuevaPuja " +
                        " where id = @idRemate " +
                        " and fechaPujaFinal = @fechaPujaFinal"; //aca esta el bloqueo optimista

                    consultaSql.Parameters.AddWithValue("?idRemate", idRemate);
                    consultaSql.Parameters.AddWithValue("?fechaActual", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    consultaSql.Parameters.AddWithValue("?usuarioNuevaPuja", usuario);
                    consultaSql.Parameters.AddWithValue("?montoNuevaPuja", monto);
                    consultaSql.Parameters.AddWithValue("?fechaPujaFinal", fechaUltimaPuja.ToString("yyyy-MM-dd HH:mm:ss"));

                    consultaSql.Connection = conn;
                    int cantRegistrosModificados = consultaSql.ExecuteNonQuery();
                    return cantRegistrosModificados;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Error al conectarce a la base");
                    return -1;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }

                }

            }
        }
    }
   
}
