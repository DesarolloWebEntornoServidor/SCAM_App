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
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Alias { get => alias; set => alias = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int Acceso { get => acceso; set => acceso = value; }
    }
}
