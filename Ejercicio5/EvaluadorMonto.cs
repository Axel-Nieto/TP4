using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorMonto: IEvaluador
    {
        private double iMontoMaximo;

        /// <summary>
        /// Crea un nuevo evaluador de monto
        /// </summary>
        /// <param name="pMontoMaximo">Monto maximo permitido</param>
        public EvaluadorMonto(double pMontoMaximo)
        {
            iMontoMaximo = pMontoMaximo;
        }

        /// <summary>
        /// Evalua si una solicitud es valida
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar</param>
        /// <returns>Devuelve true o false</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if(pSolicitud.Monto <= iMontoMaximo)
            {
                return true;
            }return false;
        }
    }
}
