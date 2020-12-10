using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class RepositorioBanca
    {
        private Banca[] iBancas;
        private static Moneda[] iMonedas = new Moneda[] { new Moneda("0001", "Pesos argentinos", "ARS"), new Moneda("0002", "Dolares estadounidenses", "USD") };

        /// <summary>
        /// Crea un objeto de tipo RespositorioBanca
        /// </summary>
        public RepositorioBanca()
        {
            this.iBancas = new Banca[0];
        }

        /// <summary>
        /// Obtiene las monedas cargadas en el repositorio
        /// </summary>
        public static Moneda[] Monedas { get { return iMonedas; } }

        /// <summary>
        /// Busca una Banca a traves del DNI
        /// </summary>
        /// <param name="pNumero">DNI de la cuenta a buscar</param>
        /// <returns>Devuelve un objeto Banca si este existe, de lo contrario devuelve null</returns>
        public Banca Obtener(string pNumero)
        {
            foreach (Banca banca in iBancas)
            {
                if (banca.Numero == pNumero)
                {
                    return banca;
                }
            }
            return null;
        }

        /// <summary>
        /// Agrega un objeto Banca al array del repositorio. Si ya existia el titular de la Banca,
        /// se sobreescribiran los datos.
        /// </summary>
        /// <param name="pBanca"></param>
        public void Agregar(Banca pBanca)
        {

            Banca[] bancasModificadas = iBancas;
            for (int i = 0; i <= iBancas.Length; i++)
            {
                if (i < iBancas.Length && pBanca.Numero == iBancas[i].Numero)
                {
                    bancasModificadas[i] = pBanca;
                    break;
                }
                if (i == iBancas.Length)
                {
                    bancasModificadas = new Banca[i + 1];
                    iBancas.CopyTo(bancasModificadas, 0);
                    bancasModificadas[i] = pBanca;
                }
            }
            iBancas = bancasModificadas;
        }
    }
}
