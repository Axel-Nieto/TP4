using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Fachada: IFachada
    {
        public void Dividir(int pDividendo, int pDivisor)
        {
            Dividir dividir = new Dividir();
            dividir.Div(pDividendo, pDivisor);
        }
    }
}
