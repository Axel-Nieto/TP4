using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public interface IFachada
    {
        public Cliente CrearCliente();
        public bool ValidarSolicitud(SolicitudPrestamo pSolicitud);
        public void CrearSolicitud(Cliente pCliente);
    }
}
