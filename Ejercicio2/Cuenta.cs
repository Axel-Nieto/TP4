using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class Cuenta
    {
        private Moneda iMoneda;
        private double iSaldo;

        /// <summary>
        /// Crea un objeto del tipo Cuenta
        /// </summary>
        /// <param name="pMoneda">Objeto de tipo Moneda</param>
        public Cuenta(Moneda pMoneda)
        {
            this.iMoneda = pMoneda;
            this.iSaldo = 0;
        }

        /// <summary>
        /// Crea un objeto del tipo Cuenta
        /// </summary>
        /// <param name="pSaldoInicial">saldo inicial en la cuenta</param>
        /// <param name="pMoneda">Objeto de tipo Moneda</param>
        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        /// <summary>
        /// Obtiene el saldo de la cuenta
        /// </summary>
        public double Saldo
        {
            get { return this.iSaldo; }
        }

        /// <summary>
        /// Agrega un monto al saldo actual de la cuenta
        /// </summary>
        /// <param name="pSaldo">Monto a acreditar</param>
        public void AcreditarSaldo(double pSaldo)
        {
            if ((pSaldo - Math.Round(pSaldo) == 0) && pSaldo >= 0)
            {
                this.iSaldo += pSaldo;
            }
            else
            {
                throw new MontoSaldoException($"Error: Monto negativo y/o decimal introduccido!");
            }                 
        }

        /// <summary>
        /// Debita un monto del saldo actual de la cuenta
        /// </summary>
        /// <param name="pSaldo">Monto a debitar</param>
        /// <returns>Si hay saldo suficiente, debita y devuelve true. Si el saldo no es suficiente devuelve false</returns>
        public bool DebitarSaldo(double pSaldo)
        {
            if ((pSaldo - Math.Round(pSaldo) == 0) && pSaldo >= 0)
            {
                if (pSaldo <= iSaldo)
                {
                    this.iSaldo -= pSaldo;
                    return true;
                }
                else return false;
            }
            else
            {
                throw new MontoSaldoException($"Error: Monto negativo y/o decimal introduccido!");
            }
        }
    }
}
