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

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idCodigoAcceso, codigoDeAcceso, descripcionAcceso, pTodos FROM codigosacceso where idCodigoAcceso={0}", id), cmd);
            MySqlDataReader cods = comando.ExecuteReader();
            while (cods.Read())
            {
                codigo.IdCodigoAcceso = cods.GetInt32(0);
                codigo.CodigoDeAcceso = cods.GetString(1);
                codigo.DescripcionAcceso = cods.GetString(2);
                codigo.PTodos = Convert.ToInt32(cods.GetBoolean(3));

            }

            cmd.Close();

            return codigo;

        }

        public static int ModificarCodigoAcceso(CodigoAcceso codA)
        {
            int retorno = 0;               

            MySqlCommand comando = new MySqlCommand(string.Format("update codigosacceso set codigoDeAcceso = '{0}', descripcionAcceso = '{1}', pTodos = '{2}' where idCodigoAcceso={3}",
                codA.CodigoDeAcceso, codA.DescripcionAcceso, codA.PTodos, codA.IdCodigoAcceso), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<int> ObtenerCodigoAccesoPorNombre(List<string> descCodigo)
        {
            List<int> codigosEnteros = new List<int>();

            for (int i = 0; i < descCodigo.Count; i++)
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT idCodigoAcceso, codigoDeAcceso, descripcionAcceso, pTodos FROM codigosacceso where descripcionAcceso='" + descCodigo[i] + "'"), Conexion.ObtenerConexion());

                MySqlDataReader cods = comando.ExecuteReader();
                while (cods.Read())
                {
                    codigosEnteros.Add(cods.GetInt32(0));

                }
            } 

            Conexion.CerrarConexion();

            return codigosEnteros;
        }

        public static List<CodigoAcceso> Localizar(string buscar)
        {
            List<CodigoAcceso> lista = new List<CodigoAcceso>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idCodigoAcceso, descripcionAcceso, pTodos FROM codigosacceso " +
                "WHERE descripcionAcceso LIKE '%" + buscar + "%'"), Conexion.ObtenerConexion());

            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                CodigoAcceso cods = new CodigoAcceso();
                cods.IdCodigoAcceso = codigos.GetInt32(0);
                cods.DescripcionAcceso = codigos.GetString(1);
                cods.PTodos = codigos.GetInt32(2);

                lista.Add(cods);
            }

            Conexion.CerrarConexion();
            return lista;
        }

        public static int BorarRegistro(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("delete FROM codigosacceso where idCodigoAcceso={0}", id), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Conexion.CerrarConexion();
            }

            return retorno;
        }

        public static List<CodigoAcceso> YaExiste(string codAcceso, string codDesc)
        {
            List<CodigoAcceso> lista = new List<CodigoAcceso>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idCodigoAcceso, codigoDeAcceso, descripcionAcceso from codigosacceso where descripcionAcceso = '{0}' ", codDesc), Conexion.ObtenerConexion());

            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                CodigoAcceso cods = new CodigoAcceso();
                cods.IdCodigoAcceso = codigos.GetInt32(0);
                cods.CodigoDeAcceso = codigos.GetString(1);
                cods.DescripcionAcceso = codigos.GetString(2);

                lista.Add(cods);
            }

            Conexion.CerrarConexion();
            return lista;
        }

    }
}
