using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Fachada: IFachada
    {
        public Fachada() { }

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <returns>Devuelve un objeto de la clase Cliente</returns>
        public Cliente CrearCliente()
        {
            string fecha, nombre, apellido;
            DateTime fechaNacimiento, fechaIngreso;
            int tipo;
            string formatoFecha = "dd/MM/yyyy";
            double salario;

            Console.Clear();
            Console.WriteLine("DATOS PERSONALES");
            Console.WriteLine("");
            Console.Write("Nombre/s: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            do
            {
                Console.Write("Fecha de Nacimiento(dd/mm/yyyy): ");
                fecha = Console.ReadLine();
                
            } while (!DateTime.TryParseExact(fecha,formatoFecha,null,System.Globalization.DateTimeStyles.None,out fechaNacimiento));
            Console.WriteLine("Tipo de cliente --> (0) no cliente, (1) cliente, (2) cliente gold, (3) cliente platinum");
            do
            {
                tipo = Convert.ToInt16(Console.ReadLine());
            } while (!(tipo >= 0 || tipo <= 3));
            Console.WriteLine("DATOS DEL EMPLEO");
            Console.WriteLine("");
            Console.Write("Salario: ");
            salario = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Fecha de Ingreso(dd/mm/yyyy): ");
                fecha = Console.ReadLine();
            } while (!DateTime.TryParseExact(fecha, formatoFecha, null, System.Globalization.DateTimeStyles.None, out fechaIngreso));
            Empleo empleo = new Empleo(salario, fechaIngreso);
            Cliente cliente = new Cliente(nombre, apellido, fechaNacimiento, empleo);
            switch (tipo)
            {
                case 0:
                    cliente.TipoCliente = TipoCliente.NoCliente;
                    break;
                case 1:
                    cliente.TipoCliente = TipoCliente.Cliente;
                    break;
                case 2:
                    cliente.TipoCliente = TipoCliente.ClienteGold;
                    break;
                case 3:
                    cliente.TipoCliente = TipoCliente.ClientePlatinum;
                    break;
            }
            return cliente;
        }


        /// <summary>
        /// Valida o rechaza una solicitud
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo a validar</param>
        /// <returns>Devuelve true o false</returns>
        public bool ValidarSolicitud(SolicitudPrestamo pSolicitud)
        {
            GestorPrestamos gestor = new GestorPrestamos();
            return gestor.EsValida(pSolicitud);
        }

        /// <summary>
        /// Crea una solicitud
        /// </summary>
        /// <param name="pCliente">Cliente que requiere la solicitud</param>
        public void CrearSolicitud(Cliente pCliente)
        {
            SolicitudPrestamo solicitudPrestamo;
            double monto;
            int cantidadCuotas;
            
            Console.WriteLine("DATOS DEL PRESTAMO");
            Console.Write("Monto: ");
            monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cantidad de cuotas: ");
            cantidadCuotas = Convert.ToInt32(Console.ReadLine());
            solicitudPrestamo = new SolicitudPrestamo(pCliente, monto, cantidadCuotas);
            if (this.ValidarSolicitud(solicitudPrestamo))
            {
                Console.WriteLine("La solicitud es válida");
            }
            else
            {
                Console.WriteLine("Error la solicitud ingresada no es válida");
            }
        }
    }
}
