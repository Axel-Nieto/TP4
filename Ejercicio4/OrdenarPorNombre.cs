using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class OrdenarPorNombre: IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            if (x.NombreCompleto.CompareTo(y.NombreCompleto) != 0)
            {
                return x.NombreCompleto.CompareTo(y.NombreCompleto);
            }
            else if (x.Codigo.CompareTo(y.Codigo) != 0)
            {
                return x.Codigo.CompareTo(y.Codigo);
            }
            else
            {
                return 0;
            }
        }
    }
}
