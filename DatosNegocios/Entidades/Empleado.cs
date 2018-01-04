using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class Empleado
    {

        int idEmpleado;
        int idDepartamento;
        string nombre;
        string apellidos;
        DateTime fechaNacto;
        string funcion;
        string dni;
        string telefono;
        string email;
        DateTime fechaEntrada;
        double salario;
        string sexo;
        string foto;
        int idUsuario;
        int activo;
 

        public Empleado()
        {
            this.idEmpleado = -1;
            this.idDepartamento = -1;
            this.nombre = String.Empty;
            this.apellidos = String.Empty;
            this.fechaNacto = fechaNacto;
            this.funcion = String.Empty;
            this.dni = String.Empty;
            this.telefono = String.Empty;
            this.email = String.Empty;
            this.fechaEntrada = fechaEntrada;
            this.salario = 0;
            this.sexo = String.Empty;
            this.foto = null;
            this.idUsuario = -1;
            this.activo = 1;
        }

        public Empleado(int idEmpleado, string nombre, string apellidos, DateTime fechaNacto, string dni, string funcion, string telefono, string email, DateTime fechaEntrada, double salario, string sexo, string foto, int idDepartamento, int idUsuario, int activo)
        {
            this.idEmpleado = idEmpleado;
            this.idDepartamento = idDepartamento;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacto = fechaNacto;
            this.funcion = funcion;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
            this.fechaEntrada = fechaEntrada;
            this.salario = salario;
            this.sexo = sexo;
            this.foto = foto;
            this.idUsuario = idUsuario;
            this.activo = activo;
        }

        public Empleado(int idEmpleado, string nombre)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
        }

        #region Propiedades
        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }

            set
            {
                idDepartamento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public DateTime FechaNacto
        {
            get
            {
                return fechaNacto;
            }

            set
            {
                fechaNacto = value;
            }
        }

        public string Funcion
        {
            get
            {
                return funcion;
            }

            set
            {
                funcion = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime FechaEntrada
        {
            get
            {
                return fechaEntrada;
            }

            set
            {
                fechaEntrada = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public int Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }
        #endregion
    }
}
