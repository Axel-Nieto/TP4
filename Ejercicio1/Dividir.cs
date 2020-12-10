using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Dividir
    {
        public void Div(int pDividendo, int pDivisor)
        {
            Matematica matematica = new Matematica();
            try
            {
                double resultado = matematica.Dividir(pDividendo, pDivisor);
                Console.WriteLine("El resultado es: " + resultado);
            }
            catch (DivisionPorCeroException e)
            {
                String mensaje = "Error: " + e.Message + ". Source: " + e.Source + ". Stack Trace: " + e.StackTrace;
                Console.WriteLine(mensaje);
            }
        }
    }
}
