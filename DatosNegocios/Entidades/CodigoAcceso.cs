using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatosNegocios
{
    public class CodigoAcceso
    {
        int idCodigoAcceso;
        string codigoDeAcceso;
        string descripcionAcceso;
        int pTodos;

        public CodigoAcceso()
        {

        }

        public CodigoAcceso(int idCodigoAcceso, string codigoDeAcceso, string descripcionAcceso, int pTodos)
        {
            this.idCodigoAcceso = idCodigoAcceso;
            this.codigoDeAcceso = codigoDeAcceso;
            this.descripcionAcceso = descripcionAcceso;
            this.pTodos = pTodos;
        }

        public CodigoAcceso(int idCodigoAcceso, string codigoDeAcceso, string descripcionAcceso)
        {
            this.idCodigoAcceso = idCodigoAcceso;
            this.codigoDeAcceso = codigoDeAcceso;
            this.descripcionAcceso = descripcionAcceso;
        }

        public int IdCodigoAcceso { get => idCodigoAcceso; set => idCodigoAcceso = value; }
        public string CodigoDeAcceso { get => codigoDeAcceso; set => codigoDeAcceso = value; }
        public string DescripcionAcceso { get => descripcionAcceso; set => descripcionAcceso = value; }
        public int PTodos { get => pTodos; set => pTodos = value; }
    }
}
