using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorCantidadCuotas: IEvaluador
    {
        private int iCantidadMaximaCuotas;

        /// <summary>
        /// Crea un nuevo evaluador de Cantidad de cuotas
        /// </summary>
        /// <param name="pCantidadMaxima">Cantidad maxima de cuotas permitidas</param>
        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            iCantidadMaximaCuotas = pCantidadMaxima;
        }

        /// <summary>
        /// Evalua si una solicitud es valida
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar</param>
        /// <returns>Devuelve true o false</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.CantidadCuotas <= iCantidadMaximaCuotas)
            {
                return true;
            }
            else return false;
        }
    }
}
