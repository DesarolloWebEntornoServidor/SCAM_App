using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            MySqlCommand comando = new MySqlCommand(String.Format("select idEmpleado, Nombre, Apellidos, FechaNacto, Dni, Funcion, Telefono, Email, FechaEntrada, Salario, Foto, IdDepartamento, idUsuario, activo from empleados"), Conexion.ObtenerConexion());
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
                emps.Foto = null;
                emps.IdDepartamento = codigos.GetInt32(11);

                lista.Add(emps);
            }

            return lista;
        }

        public static Empleado ObtenerEmpleado(int id)
        {
            Empleado emps = new Empleado();
            DateTime data = new DateTime();

            MySqlConnection cmd = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("select idEmpleado, Nombre, Apellidos, FechaNacto, Dni, Funcion, Telefono, Email, FechaEntrada, Salario, Sexo, Foto, IdDepartamento, idUsuario, activo from empleados where idEmpleado={0}", id), cmd);
            MySqlDataReader empleados = comando.ExecuteReader();
            while (empleados.Read())
            {
                emps.IdEmpleado = empleados.GetInt32(0);
                emps.Nombre = empleados.GetString(1);
                emps.Apellidos = empleados.GetString(2);
                emps.FechaNacto = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);
                emps.Dni = empleados.GetString(4);
                emps.Funcion = empleados.GetString(5);
                emps.Telefono = empleados.GetString(6);
                emps.Email = empleados.GetString(7);
                emps.FechaEntrada = Convert.ToDateTime(data.Year + "/" + data.Month + "/" + data.Day);
                emps.Salario = empleados.GetDouble(9);
                emps.Sexo = empleados.GetString(10);
                emps.Foto = null;
                emps.IdDepartamento = empleados.GetInt32(12);

            }

            cmd.Close();

            return emps;

        }
    }
}
