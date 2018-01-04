using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class Usuario
    {
        int idUsuario;
        string nombre;
        string alias;
        string login;
        string password;
        int acceso;

        public Usuario()
        {
        }

        public Usuario(string nombre, string alias, string login, string password, int acceso)
        {
            this.nombre = nombre;
            this.alias = alias;
            this.login = login;
            this.password = password;
            this.acceso = acceso;
        }

        public Usuario(string login) // constructor para el combo en inserir empleado
        {
            this.login = login;
        }
        #region Propiedades
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

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Acceso
        {
            get
            {
                return acceso;
            }

            set
            {
                acceso = value;
            }
        }
        #endregion
    }
}
