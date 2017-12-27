using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Datos.controldeaccesosmagneticoDataSetTableAdapters;

namespace DatosNegocios
{
    public class CodigoAccesoDAO
    {

        public static int Insertar(CodigoAcceso codA)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into codigosacceso (codigoDeAcceso, descripcionAcceso, pTodos) values ('{0}','{1}','{2}')",
                Util.Encriptar(codA.CodigoDeAcceso), codA.DescripcionAcceso, codA.PTodos), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<CodigoAcceso> ListarCodigosAcceso()
        {
            List<CodigoAcceso> lista = new List<CodigoAcceso>();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idCodigoAcceso, descripcionAcceso, pTodos FROM codigosacceso"), Conexion.ObtenerConexion());
            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                CodigoAcceso cods = new CodigoAcceso();
                cods.IdCodigoAcceso = codigos.GetInt32(0);
                cods.DescripcionAcceso = codigos.GetString(1);
                cods.PTodos = codigos.GetInt32(2);


                lista.Add(cods);
            }

            return lista;
        }

        public static CodigoAcceso ObtenerCodigoAcceso(int id)
        {
            CodigoAcceso codigo = new CodigoAcceso();

            MySqlConnection cmd = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idCodigoAcceso, codigoDeAcceso, descripcionAcceso FROM codigosacceso where idCodigoAcceso={0}", id), cmd);
            MySqlDataReader cods = comando.ExecuteReader();
            while (cods.Read())
            {
                codigo.IdCodigoAcceso = cods.GetInt32(0);
                codigo.CodigoDeAcceso = cods.GetString(1);
                codigo.DescripcionAcceso = cods.GetString(2);

            }

            cmd.Close();

            return codigo;

        }

        public static List<int> ObtenerCodigoAccesoPorNombre(List<string> descCodigo)
        {
            List<int> codigosEnteros = new List<int>();

            for (int i = 0; i < descCodigo.Count; i++)
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT idCodigoAcceso, codigoDeAcceso, descripcionAcceso FROM codigosacceso where descripcionAcceso='" + descCodigo[i] + "'"), Conexion.ObtenerConexion());

                MySqlDataReader cods = comando.ExecuteReader();
                while (cods.Read())
                {
                    codigosEnteros.Add(cods.GetInt32(0));

                }
            } 

            Conexion.CerrarConexion();

            return codigosEnteros;
        }
    }
}
