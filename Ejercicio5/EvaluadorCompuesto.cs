using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorCompuesto : IEvaluador
    {
        List<IEvaluador> iEvaluadores = new List<IEvaluador>();

        /// <summary>
        /// Crea un Evaluador Compuesto (Contiene a todos los evaluadores)
        /// </summary>
        public EvaluadorCompuesto()
        {
        }

        /// <summary>
        /// Evalua si una solicitud es valida
        /// </summary>
        /// <param name="pSolicitud">Solicitud a evaluar</param>
        /// <returns>Devuelve true o false</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int i = 0;
            bool valido = true;
            while (valido == true && i < iEvaluadores.Count)
            {
                valido = iEvaluadores[i].EsValida(pSolicitud);
                i++;
            }
            return valido;
        }

        /// <summary>
        /// Agrega un evaluador
        /// </summary>
        /// <param name="pEvaluador"></param>
        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }
    }
}
