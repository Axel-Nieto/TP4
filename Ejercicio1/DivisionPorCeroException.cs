using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class DivisionPorCeroException: Exception
    {
        public DivisionPorCeroException(String mensaje): base(mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
