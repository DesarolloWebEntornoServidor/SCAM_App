using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class AccesoEmpleadoDAO
    {
        public static int Insertar(AccesoEmpleados ace)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into accesosempleados (idEmpleado, idCodigoAcceso, fechaEntrada) values ('{0}','{1}','{2}')",
                ace.IdEmpleado, ace.IdCodAcceso, ace.FechaEntrada ), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            Conexion.CerrarConexion();

            return retorno;
        }

        public static List<AccesoEmpleados> ListarAccesosdeEmpleados()
        {
            List<AccesoEmpleados> lista = new List<AccesoEmpleados>();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idAccesosEmpleados, idEmpleado, idCodigoAcceso, fechaEntrada FROM accesosempleados order by idEmpleado, idCodigoAcceso"), Conexion.ObtenerConexion());
            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                AccesoEmpleados cods = new AccesoEmpleados();
                DateTime data = new DateTime();

                cods.IdAccesoEmpleado = codigos.GetInt32(0);
                cods.IdEmpleado = codigos.GetInt32(1);
                cods.IdCodAcceso = codigos.GetInt32(2);
                cods.FechaEntrada = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);

                lista.Add(cods);
            }

            Conexion.CerrarConexion();
            return lista;
        }
        public static List<int> ObtenerAccesosdelEmpleado(int id)
        {

            MySqlCommand comma = new MySqlCommand(); // crea  una variable para sacar la cantidad de registros que vendrá en la query

            comma.Connection = Conexion.ObtenerConexion();

            List<int> lista = new List<int>(); // crea una lista que llevara los codigos de acceso

            string query = String.Format("SELECT idCodigoAcceso  FROM accesosempleados where idEmpleado='{0}' order by idCodigoAcceso", id);

            MySqlCommand cmd = new MySqlCommand(query, Conexion.ObtenerConexion()); // crea una variable para sacar los codigos de accesos que tiene el empleado
            MySqlDataReader dr = cmd.ExecuteReader();

            comma.CommandText = string.Format("select count(*) FROM accesosempleados where idEmpleado={0}", id); // saca la cantidad de objetos en la query

            int valor = int.Parse(comma.ExecuteScalar().ToString()); // converte el resultado desta, en numerico entero

            string[] s = new string[] { }; // crea una tabla vazia para desmenbrar el resultado de la query

            string[] enteros = new string[valor]; // crea una tabla para recibir los valores del split da variable query, con los codigos de acceso del empleado

            int cont = 0;

            while (dr.Read())
            {
                s = dr["idCodigoAcceso"].ToString().Split(',');
                enteros[cont] = s[0].ToString();
                lista.Add(Convert.ToInt32(enteros[cont]));
                cont++;
            }

            Conexion.CerrarConexion();

            return lista;
        }

        public static List<AccesoEmpleados> Localizar(string buscar)
        {

            List<AccesoEmpleados> lista = new List<AccesoEmpleados>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idAccesosEmpleados, ac.idEmpleado, ac.idCodigoAcceso, ac.fechaEntrada from accesosempleados ac " +
                "join empleados e on(ac.idEmpleado= e.idEmpleado) join codigosacceso c on(ac.idCodigoAcceso= c.idCodigoAcceso) " +
                "WHERE e.nombre LIKE '%" + buscar + "%' OR e.apellidos LIKE '%" + buscar + "%' OR e.dni LIKE '%" + buscar + "%' " +
                "OR c.descripcionAcceso LIKE '%" + buscar + "%'"), Conexion.ObtenerConexion());

            MySqlDataReader codigos = comando.ExecuteReader();

            while (codigos.Read())
            {
                AccesoEmpleados cods = new AccesoEmpleados();
                DateTime data = new DateTime();

                cods.IdAccesoEmpleado = codigos.GetInt32(0);
                cods.IdEmpleado = codigos.GetInt32(1);
                cods.IdCodAcceso = codigos.GetInt32(2);
                cods.FechaEntrada = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);

                lista.Add(cods);
            }

            Conexion.CerrarConexion();
            return lista;

        }

        public static int InsertarGrupoAccesos(int idEmp, List<string> nombreCodigosChecados) // recibo el codigo del empleado y la lista con los nombres de los codigos de acceso actuales asignados al empleado
        {
            int retorno = 0, tamanyo = nombreCodigosChecados.Count;
            List<int> ace = null;

            ace = CodigoAccesoDAO.ObtenerCodigoAccesoPorNombre(nombreCodigosChecados);

            BorarVariosRegistros(idEmp);

            for (int i = 0; i < ace.Count; i++)
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into accesosempleados (idEmpleado, idCodigoAcceso) values ('{0}','{1}')", idEmp, ace[i]), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();

            }


            // tengo que borrar todos los codigos asignados antes de insertar estos //////////////////////////////////////////

            Conexion.CerrarConexion();


            return retorno;
        }

        public static void BorarRegistro(int codAcceso)
        {

            MySqlCommand comando = new MySqlCommand(string.Format("delete FROM accesosempleados where idAccesosEmpleados={0}", codAcceso), Conexion.ObtenerConexion());

            comando.ExecuteNonQuery();

            Conexion.CerrarConexion();
        }

        public static void BorarVariosRegistros(int codEmpleado) // recibo el codigo del empleado que voy borrar los accesos antes de insertar los nuevos
        {

            MySqlCommand comando = new MySqlCommand(string.Format("delete FROM accesosempleados where idEmpleado={0}", codEmpleado), Conexion.ObtenerConexion());

            comando.ExecuteNonQuery();

            Conexion.CerrarConexion();
        }

        public static AccesoEmpleados ObtenerCodigoAcceso(int id)
        {
            AccesoEmpleados cods = new AccesoEmpleados();
            DateTime data = new DateTime();

            MySqlConnection cmd = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idEmpleado, idCodigoAcceso, fechaEntrada FROM accesosempleados where idAccesosEmpleados={0}", id), cmd);
            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                cods.IdEmpleado = codigos.GetInt32(0);
                cods.IdCodAcceso = codigos.GetInt32(1);
                cods.FechaEntrada = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);

            }

            cmd.Close();

            return cods;

        }

  
    }
}
