using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class Banca
    {
        private String iNumero;
        private String iTitular;
        private Cuenta iCuentaEnPesos;
        private Cuenta iCuentaEnDolares;

        /// <summary>
        /// Crea un objeto de tipo Banca
        /// </summary>
        /// <param name="pNumero">DNI del titular</param>
        /// <param name="pTitular">Nombre del titular</param>
        public Banca(String pNumero, String pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
            this.iCuentaEnPesos = new Cuenta(RepositorioBanca.Monedas[0]);
            this.iCuentaEnDolares = new Cuenta(RepositorioBanca.Monedas[1]);
        }

        /// <summary>
        /// Obtiene el DNI del titular de la Banca
        /// </summary>
        public String Numero { get { return this.iNumero; } }

        /// <summary>
        /// Obtiene el nombre del titular de la Banca
        /// </summary>
        public String Titular { get { return this.iTitular; } }

        /// <summary>
        /// Obtiene la cuenta en pesos del titular de la Banca
        /// </summary>
        public Cuenta CuentaEnPesos { get { return this.iCuentaEnPesos; } }

        /// <summary>
        /// Obtiene la cuenta en dolares del titular de la Banca
        /// </summary>
        public Cuenta CuentaEnDolares { get { return this.iCuentaEnDolares; } }
    }
}
