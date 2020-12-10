using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class OrdenarPorCodigo: IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.CompareTo(y);
        }
    }
}
