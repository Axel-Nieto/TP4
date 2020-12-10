using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Matematica
    {
        public Matematica(){}
        
        public double Dividir(int pDividendo,int pDivisor)
        {
            if (pDivisor!=0)
            {
                return pDividendo / pDivisor;
            }
            else
            {
                throw new DivisionPorCeroException($"No se puede dividir por cero");
            }
        }
    }
}
