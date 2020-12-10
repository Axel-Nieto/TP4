using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class Moneda
    {
        private String iCodigoISO;
        private String iNombre;
        private String iSimbolo;

        /// <summary>
        /// Crea un objeto de tipo Moneda
        /// </summary>
        /// <param name="pCodigoISO">Codigo ISO</param>
        /// <param name="pNombre">Nombre de la moneda</param>
        /// <param name="pSimbolo">Simbolo de la moneda</param>
        public Moneda(String pCodigoISO, String pNombre, String pSimbolo)
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        /// <summary>
        /// Obtiene el codigo ISO de la moneda
        /// </summary>
        public String CodigoISO { get { return this.iCodigoISO; } }

        /// <summary>
        /// Obtiene el nombre de la moneda
        /// </summary>
        public String Nombre { get { return this.iNombre; } }

        /// <summary>
        /// Obtiene el simbolo de la moneda
        /// </summary>
        public String Simbolo { get { return this.iSimbolo; } }
    }
}
