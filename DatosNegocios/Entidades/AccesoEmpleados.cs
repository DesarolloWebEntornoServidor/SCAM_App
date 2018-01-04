using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNegocios
{
    public class AccesoEmpleados
    {
        int idAccesoEmpleado;
        int idEmpleado;
        int idCodAcceso;
        DateTime fechaEntrada;

        public AccesoEmpleados()
        {
        }

        public AccesoEmpleados(int idEmpleado, int idCodAcceso, DateTime fechaEntrada)
        {
            this.idEmpleado = idEmpleado;
            this.idCodAcceso = idCodAcceso;
            this.fechaEntrada = fechaEntrada;
        }

        public int IdAccesoEmpleado        {
            get
            {
                return idAccesoEmpleado;
            }

            set
            {
                idAccesoEmpleado = value;
            }
        }

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

        public int IdCodAcceso 
        {
            get
            {
                return idCodAcceso;
            }

            set
            {
                idCodAcceso = value;
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
    }
}
