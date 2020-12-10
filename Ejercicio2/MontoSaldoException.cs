using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class MontoSaldoException: Exception
    {
        public MontoSaldoException(String mensaje): base(mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
