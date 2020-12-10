using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorEdad: IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        /// <summary>
        /// Crea un evaluador de edad
        /// </summary>
        /// <param name="pEdadMinima">Edad minima permitida</param>
        /// <param name="pEdadMaxima">Edad maxima permitida</param>
        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            iEdadMinima = pEdadMinima;
            iEdadMaxima = pEdadMaxima;
        }

        /// <summary>
        /// Evalua si una solicitud es valida
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar</param>
        /// <returns>Devuelve true o false</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaNacimiento = pSolicitud.Cliente.FechaNacimiento;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if ((fechaNacimiento.Month > DateTime.Today.Month) || (fechaNacimiento.Month == DateTime.Today.Month && fechaNacimiento.Day > DateTime.Today.Day))
            {
                edad--;
            }
            if (edad > iEdadMinima && edad < iEdadMaxima)
            {
                return true;
            }
            else return false;
        }
    }
}
