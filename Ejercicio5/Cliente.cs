using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Cliente
    {
        private String iNombre;
        private String iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente;
        private Empleo iEmpleo;

        /// <summary>
        /// Crea un nuevo cliente
        /// </summary>
        /// <param name="pNombre">Nombre del cliente</param>
        /// <param name="pApellido">Apellido del cliente</param>
        /// <param name="pFechaNacimiento">Fecha de Nacimiento del cliente</param>
        /// <param name="pEmpleo">Empleo actual del cliente</param>
        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iFechaNacimiento = pFechaNacimiento;
            iTipoCliente = 0;
            iEmpleo = pEmpleo;
        }

        public String Nombre { get { return iNombre; } }
        public String Apellido { get { return iApellido; } }
        public DateTime FechaNacimiento { get { return iFechaNacimiento; } }
        public Empleo Empleo { get { return iEmpleo; } }
        public TipoCliente TipoCliente 
        { 
            get { return iTipoCliente; } 
            set { iTipoCliente = value; }
        }
    }
}
