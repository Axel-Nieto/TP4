using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorSueldo: IEvaluador
    {
        private double iSueldoMinimo;

        /// <summary>
        /// Crea un nuevo evaluador de sueldo
        /// </summary>
        /// <param name="pSueldoMinimo">Sueldo minimo permitido</param>
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            iSueldoMinimo = pSueldoMinimo;
        }

        /// <summary>
        /// Evalua si una solicitud es valida
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar</param>
        /// <returns>Devuelve true o false</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Cliente.Empleo.Sueldo >= iSueldoMinimo)
            {
                return true;
            }
            else return false;
        }
    }
}
