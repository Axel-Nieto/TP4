using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class SolicitudPrestamo
    {
        private Cliente iCliente;
        private double iMonto;
        private int iCantidadCuotas;

        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            iCliente = pCliente;
            iMonto = pMonto;
            iCantidadCuotas = pCantidadCuotas;
        }

        public double Monto { get { return iMonto; } }
        public int CantidadCuotas { get { return iCantidadCuotas; } }
        public Cliente Cliente { get { return iCliente; } }
    }
}
