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
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public int IdCodigoAcceso { get => idCodigoAcceso; set => idCodigoAcceso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
