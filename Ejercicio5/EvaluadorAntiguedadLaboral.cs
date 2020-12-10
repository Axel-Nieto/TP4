using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorAntiguedadLaboral: IEvaluador
    {
        private int iAntiguedadMinima;

        /// <summary>
        /// Crea un nuevo evaluador de antiguedad laboral
        /// </summary>
        /// <param name="pAntiguedadMinima">Antiguedad minima requerida</param>
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            iAntiguedadMinima = pAntiguedadMinima;
        }

        /// <summary>
        /// Evalua si una solicitud es valida
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar</param>
        /// <returns>Devuelve true o false</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaActual = DateTime.Today;
            if (fechaActual.Subtract(pSolicitud.Cliente.Empleo.FechaIngreso).TotalDays > iAntiguedadMinima * 30)
            {
                return true;
            }
            else return false;
        }
    }
}
