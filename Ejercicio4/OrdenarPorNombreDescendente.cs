using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class OrdenarPorNombreDescendente: IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            if (x.NombreCompleto.CompareTo(y.NombreCompleto) != 0)
            {
                return y.NombreCompleto.CompareTo(x.NombreCompleto);
            }
            else if (x.Codigo.CompareTo(y.Codigo) != 0)
            {
                return y.Codigo.CompareTo(x.Codigo);
            }
            else
            {
                return 0;
            }
        }
    }
}
