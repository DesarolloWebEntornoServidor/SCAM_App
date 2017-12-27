using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data; 



namespace DatosNegocios
{
    public class Conexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=controldeaccesosmagnetico; Uid=root; pwd=altair;");

            conectar.Open();
            return conectar;
        }

        public static MySqlConnection CerrarConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=controldeaccesosmagnetico; Uid=root; pwd=altair;");

            conectar.Close();
            return conectar;
        }

    }

}

