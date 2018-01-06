using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class UsuarioDAO
    {
        public static int Insertar(Usuario usu)
        {
          int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios (nombre, alias, login, password, acceso) values ('{0}','{1}','{2}','{3}','{4}')",
                usu.Nombre, usu.Alias, usu.Login, Util.Encriptar(usu.Password), usu.Acceso), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idUsuario, nombre, alias, login, password, acceso from usuarios"), Conexion.ObtenerConexion());
            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                Usuario usus = new Usuario();
                usus.IdUsuario = codigos.GetInt32(0);
                usus.Nombre = codigos.GetString(1);
                usus.Alias = codigos.GetString(2);
                usus.Login = codigos.GetString(3);
                usus.Password = codigos.GetString(4);
                usus.Acceso = codigos.GetInt32(5);

                lista.Add(usus);
            }

            return lista;
        }

        public static Usuario ObtenerUsuario(string login)
        {
                Usuario usus = new Usuario();

                MySqlCommand comando = new MySqlCommand(String.Format("select idUsuario, nombre, alias, login, password, acceso from usuarios where login='" + login + "'"), Conexion.ObtenerConexion());
                MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                usus.IdUsuario = codigos.GetInt32(0);
                usus.Nombre = codigos.GetString(1);
                usus.Alias = codigos.GetString(2);
                usus.Login = codigos.GetString(3);
                usus.Password = codigos.GetString(4);
                usus.Acceso = codigos.GetInt32(5);

            }

            Conexion.CerrarConexion();

            return usus;
        }

        public static bool verificaUsuario(string usuario, string pass)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = Conexion.ObtenerConexion();
            try
            {
                cmd.CommandText = string.Format("select count(*) from usuarios where login = '{0}' and password = '{1}'", usuario, Util.Encriptar(pass));

                int valor = int.Parse(cmd.ExecuteScalar().ToString());

                if (valor == 1)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }

            Conexion.CerrarConexion();

            return false;
        }

        public static List<Usuario> YaExiste(string usuario, string alias)
        {
            List<Usuario> lista = new List<Usuario>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idUsuario, nombre from usuarios where login = '{0}' or alias = '{1}'", usuario, alias), Conexion.ObtenerConexion());
            MySqlDataReader codigos = comando.ExecuteReader();

            Usuario usus = new Usuario();

            while (codigos.Read())
                {
                    usus.IdUsuario = codigos.GetInt32(0);
                    usus.Nombre = codigos.GetString(1);


                    lista.Add(usus);
                }

                return lista;
            }

   
        public static int BorarRegistro(int codUsuario)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("delete FROM usuarios where idUsuario={0}", codUsuario), Conexion.ObtenerConexion());

               retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Conexion.CerrarConexion();
            }

            return retorno;

        }

        public static int ModificarUsuario(Usuario usu) // Modificar Usuario // 
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update usuarios set nombre = '{0}', alias = '{1}', login = '{2}', password = '{3}', acceso = '{4}' where idUsuario = " +
                "{5}", usu.Nombre, usu.Alias, usu.Login, Util.Encriptar(usu.Password), usu.Acceso, usu.IdUsuario), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Usuario> Localizar(string buscar)
        {

            List<Usuario> lista = new List<Usuario>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idUsuario, nombre, alias, login, acceso from usuarios u " +
                "WHERE nombre LIKE '%" + buscar + "%' OR alias LIKE '%" + buscar + "%' OR login LIKE '%" + buscar + "%' " +
                "OR acceso LIKE '%" + buscar + "%'"), Conexion.ObtenerConexion());

            MySqlDataReader codigos = comando.ExecuteReader();

            while (codigos.Read())
            {
                Usuario cods = new Usuario();

                cods.IdUsuario = codigos.GetInt32(0);
                cods.Nombre = codigos.GetString(1);
                cods.Alias = codigos.GetString(2);
                cods.Login = codigos.GetString(3);
                cods.Acceso = codigos.GetInt32(4);

                lista.Add(cods);
            }

            Conexion.CerrarConexion();
            return lista;

        }

        public static Usuario ObtenerUsuario(int idUsu)
        {
            Usuario usus = new Usuario();

            MySqlCommand comando = new MySqlCommand(String.Format("select idUsuario, nombre, alias, login, password, acceso from usuarios where idUsuario='" + idUsu + "'"), Conexion.ObtenerConexion());
            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                usus.IdUsuario = codigos.GetInt32(0);
                usus.Nombre = codigos.GetString(1);
                usus.Alias = codigos.GetString(2);
                usus.Login = codigos.GetString(3);
                usus.Password = codigos.GetString(4);
                usus.Acceso = codigos.GetInt32(5);

            }

            Conexion.CerrarConexion();

            return usus;
        }
    }
}
