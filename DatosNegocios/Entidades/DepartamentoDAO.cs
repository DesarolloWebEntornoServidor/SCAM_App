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

            MySqlCommand comando = new MySqlCommand(String.Format("select idDepartamento, descripcion, idCodigoAcceso from departamentos"), Conexion.ObtenerConexion());
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

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idDepartamento, descripcion, idCodigoAcceso FROM departamentos where idDepartamento={0}", id), cmd);
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
    }
}
