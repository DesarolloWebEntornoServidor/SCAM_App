using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data; 



namespace Datos_Negocios
{
    public class Conexion
    {

        public static MySqlConnection Conectar()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=controldeaccesosmagnetico; Uid=root; pwd=altair;");

            conectar.Open();
            return conectar;
        }

        //public static MySqlConnection Desconectar()
        //{
            
        //    return mySqlConnection.Close();
        //}


    }

}

