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

        #region Propiedades

        public int IdCodigoAcceso
        {
            get
            {
                return idCodigoAcceso;
            }

            set
            {
                idCodigoAcceso = value;
            }
        }

        public string CodigoDeAcceso
        {
            get
            {
                return codigoDeAcceso;
            }

            set
            {
                codigoDeAcceso = value;
            }
        }

        public string DescripcionAcceso
        {
            get
            {
                return descripcionAcceso;
            }

            set
            {
                descripcionAcceso = value;
            }
        }

        public int PTodos
        {
            get
            {
                return pTodos;
            }

            set
            {
                pTodos = value;
            }
        }
        #endregion
    }
}
