using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class DepartamentoDAO
    {
        public static int Insertar(Departamento dep)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into departamentos (descripcion, idCodigoAcceso) values ('{0}','{1}')",
                dep.Descripcion, dep.IdCodigoAcceso), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Departamento> ListarDepartamentos()
        {
            List<Departamento> lista = new List<Departamento>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idDepartamento, descripcion, idCodigoAcceso from departamentos order by descripcion"), Conexion.ObtenerConexion());
            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                Departamento deps = new Departamento();
                deps.IdDepartamento = codigos.GetInt32(0);
                deps.Descripcion = codigos.GetString(1);
                deps.IdCodigoAcceso = codigos.GetInt32(2);

                lista.Add(deps);
            }

            return lista;
        }

        public static Departamento ObtenerDepartamento(int id)
        {
            Departamento depart = new Departamento();

            MySqlConnection cmd = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("select idDepartamento, descripcion, idCodigoAcceso FROM departamentos where idDepartamento={0}", id), cmd);
            MySqlDataReader cods = comando.ExecuteReader();
            while (cods.Read())
            {
                depart.IdDepartamento = cods.GetInt32(0);
                depart.Descripcion = cods.GetString(1);
                depart.IdCodigoAcceso = cods.GetInt32(2);

            }

            cmd.Close();

            return depart;

        }

        public static List<Departamento> Localizar(string buscar)
        {
            List<Departamento> lista = new List<Departamento>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idDepartamento, descripcion, d.idCodigoAcceso from departamentos d " +
                "join codigosacceso c on (d.idCodigoAcceso=c.idCodigoAcceso)" +
                "WHERE descripcion LIKE '%" + buscar + "%' OR c.descripcionAcceso LIKE '%" + buscar + "%' OR d.idCodigoAcceso LIKE '%" + buscar + "%'"), Conexion.ObtenerConexion());

            MySqlDataReader cods = comando.ExecuteReader();

            while (cods.Read())
            {
                Departamento depart = new Departamento();

                depart.IdDepartamento = cods.GetInt32(0);
                depart.Descripcion = cods.GetString(1);
                depart.IdCodigoAcceso = cods.GetInt32(2);

                lista.Add(depart);
            }

            Conexion.CerrarConexion();
            return lista;
        }

        public static int ModificarDepartamento(Departamento dep)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update departamentos set descripcion = '{0}', idCodigoAcceso = '{1}' where idDepartamento={2}",
                dep.Descripcion, dep.IdCodigoAcceso, dep.IdDepartamento), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int BorarRegistro(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("delete from departamentos where idDepartamento={0}", id), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                Conexion.CerrarConexion();
            }

            return retorno;
            
        }

        public static List<Departamento> yaExiste(string dep)
        {
            List<Departamento> lista = new List<Departamento>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idDepartamento, descripcion from departamentos where descripcion = '{0}'", dep), Conexion.ObtenerConexion());

            MySqlDataReader cods = comando.ExecuteReader();

            while (cods.Read())
            {
                Departamento depart = new Departamento();

                depart.IdDepartamento = cods.GetInt32(0);
                depart.Descripcion = cods.GetString(1);

                lista.Add(depart);
            }

            return lista;
        }


    }
}
