using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatosNegocios
{
    public class EmpleadoDAO
    {
        public static int Insertar(Empleado emp)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into empleados (nombre, apellidos, fechaNacto, dni, funcion, telefono, email, fechaEntrada, salario, sexo, foto, idDepartamento, idUsuario, activo) values ('{0}','{1}','{2:yyyy/MM/dd HH:mm}','{3}','{4}','{5}','{6}','{7:yyyy/MM/dd HH:mm}','{8}','{9}','{10}','{11}','{12}','{13}')",
                emp.Nombre, emp.Apellidos, emp.FechaNacto, emp.Dni, emp.Funcion, emp.Telefono, emp.Email, emp.FechaEntrada, emp.Salario, emp.Sexo, emp.Foto, emp.IdDepartamento, emp.IdUsuario, emp.Activo), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Empleado> ListarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idEmpleado, Nombre, Apellidos, FechaNacto, Dni, Funcion, Telefono, Email, FechaEntrada, " +
                "Salario, sexo, Foto, IdDepartamento, idUsuario, activo from empleados order by nombre"), Conexion.ObtenerConexion());

            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                DateTime data = new DateTime();
                Empleado emps = new Empleado();

                emps.IdEmpleado = codigos.GetInt32(0);
                emps.Nombre = codigos.GetString(1);
                emps.Apellidos = codigos.GetString(2);
                emps.FechaNacto = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);
                emps.Dni = codigos.GetString(4);
                emps.Funcion = codigos.GetString(5);
                emps.Telefono = codigos.GetString(6);
                emps.Email = codigos.GetString(7);
                emps.FechaEntrada = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);
                emps.Salario = codigos.GetDouble(9);
                emps.Sexo = codigos.GetString(10);
                if (codigos.GetString(11) != null)
                    emps.Foto = codigos.GetString(11);
                else
                    emps.Foto = "";
                emps.IdDepartamento = codigos.GetInt32(12);
                emps.IdUsuario = codigos.GetInt32(13);
                emps.Activo = Convert.ToInt32( codigos.GetBoolean(14));

                lista.Add(emps);
            }

            return lista;
        }

        public static Empleado BuscarEmpleadoVinculado(int idUsuario) // Retorna el empleado que esta vinculado al usuario para ser modificado //
        {
            Empleado emps = new Empleado();

            MySqlConnection cmd = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("select idEmpleado, Nombre from empleados where idUsuario={0}", idUsuario), cmd);
            MySqlDataReader empleados = comando.ExecuteReader();
            while (empleados.Read())
            {
                emps.IdEmpleado = empleados.GetInt32(0);
                emps.Nombre = empleados.GetString(1);
            }

            cmd.Close();

            return emps;
        }

        public static List<Empleado> Localizar(string buscar)
        {
            List<Empleado> lista = new List<Empleado>();

            MySqlCommand comando = new MySqlCommand(String.Format("select idEmpleado, Nombre, Apellidos, FechaNacto, Dni, Funcion, Telefono, Email, FechaEntrada, " +
                "Salario, sexo, Foto, e.IdDepartamento, idUsuario, activo from empleados e join departamentos d on (e.idDepartamento=d.idDepartamento)" +
                "WHERE descripcion LIKE '%" + buscar + "%' OR nombre LIKE '%" + buscar + "%' OR apellidos LIKE '%" + buscar + "%' OR email LIKE '%" + buscar + "%' " +
                "OR dni LIKE '%" + buscar + "%' OR funcion LIKE '%" + buscar + "%' OR telefono LIKE '%" + buscar + "%' OR fechaNacto LIKE '%" + buscar + "%' " +
                "OR fechaEntrada LIKE '%" + buscar + "%'"), Conexion.ObtenerConexion());

            MySqlDataReader codigos = comando.ExecuteReader();
            while (codigos.Read())
            {
                Empleado emps = new Empleado();

                emps.IdEmpleado = codigos.GetInt32(0);
                emps.Nombre = codigos.GetString(1);
                emps.Apellidos = codigos.GetString(2);
                emps.FechaNacto = codigos.GetDateTime(3);
                emps.Dni = codigos.GetString(4);
                emps.Funcion = codigos.GetString(5);
                emps.Telefono = codigos.GetString(6);
                emps.Email = codigos.GetString(7);
                emps.FechaEntrada = codigos.GetDateTime(8);
                emps.Salario = codigos.GetDouble(9);
                emps.Sexo = codigos.GetString(10);
                if (codigos.GetString(11) != null)
                    emps.Foto = codigos.GetString(11);
                else
                    emps.Foto = "";
                emps.IdDepartamento = codigos.GetInt32(12);
                emps.IdUsuario = codigos.GetInt32(13);
                emps.Activo = Convert.ToInt32(codigos.GetBoolean(14));

                lista.Add(emps);
            }

            Conexion.CerrarConexion();
            return lista;
        }

        public static int VincularUsuario(int idEmp, Usuario Usuar)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update empleados set idUsuario={0} where idEmpleado={1}", Usuar.IdUsuario, idEmp), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarEmpleado(Empleado emp)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update empleados set nombre='{0}', apellidos='{1}', fechaNacto='{2:yyyy/MM/dd HH:mm}', dni='{3}', funcion='{4}', " +
                "telefono='{5}', email='{6}', fechaEntrada='{7:yyyy/MM/dd HH:mm}', salario='{8}', sexo='{9}', foto='{10}', idDepartamento='{11}', idUsuario='{12}', activo='{13}' " +
                "where idEmpleado = {14}", emp.Nombre, emp.Apellidos, emp.FechaNacto, emp.Dni, emp.Funcion, emp.Telefono, emp.Email, emp.FechaEntrada, emp.Salario, emp.Sexo, 
                emp.Foto, emp.IdDepartamento, emp.IdUsuario, emp.Activo, emp.IdEmpleado), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static Empleado ObtenerEmpleado(int id)
        {
            Empleado emps = new Empleado();

            MySqlConnection cmd = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("select idEmpleado, Nombre, Apellidos, FechaNacto, Dni, Funcion, Telefono, Email, FechaEntrada, Salario, Sexo, Foto, IdDepartamento, idUsuario, activo from empleados where idEmpleado={0}", id), cmd);
            MySqlDataReader empleados = comando.ExecuteReader();

            while (empleados.Read())
            {
                emps.IdEmpleado = empleados.GetInt32(0);
                emps.Nombre = empleados.GetString(1);
                emps.Apellidos = empleados.GetString(2);
                emps.FechaNacto = empleados.GetDateTime(3);
                emps.Dni = empleados.GetString(4);
                emps.Funcion = empleados.GetString(5);
                emps.Telefono = empleados.GetString(6);
                emps.Email = empleados.GetString(7);
                emps.FechaEntrada = empleados.GetDateTime(8);
                emps.Salario = empleados.GetDouble(9);
                emps.Sexo = empleados.GetString(10);
                if(empleados.GetString(11) != null)
                   emps.Foto = empleados.GetString(11);
                else
                    emps.Foto = "";
                emps.IdDepartamento = empleados.GetInt32(12);
                emps.IdUsuario = empleados.GetInt32(13);
                emps.Activo = Convert.ToInt32(empleados.GetBoolean(14));

            }


            cmd.Close();


            return emps;

        }

        public static int BorarRegistro(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("delete FROM empleados where idEmpleado={0}", id), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Conexion.CerrarConexion();
            }

            return retorno;
        }
    }
}
