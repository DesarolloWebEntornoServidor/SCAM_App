using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class Departamento
    {
        int idDepartamento;
        int idCodigoAcceso;
        string descripcion;

        public Departamento()
        {
            this.idDepartamento = -1;
            this.idCodigoAcceso = -1;
            this.descripcion = String.Empty;
        }

        public Departamento(int idDepartamento, int idCodigoAcceso, string descripcion)
        {
            this.idDepartamento = idDepartamento;
            this.idCodigoAcceso = idCodigoAcceso;
            this.descripcion = descripcion;
        }

        #region Propiedades
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
        #endregion
    }
}
