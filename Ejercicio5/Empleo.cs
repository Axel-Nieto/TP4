using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        /// <summary>
        /// Crea un nuevo empleo
        /// </summary>
        /// <param name="pSueldo">Sueldo del trabajador</param>
        /// <param name="pFechaIngreso">Fecha de ingreso del trabajador</param>
        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            iSueldo = pSueldo;
            iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo { get { return iSueldo; } }
        public DateTime FechaIngreso{ get { return iFechaIngreso; } }
    }
}
