using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class FachadaImp: IFachada
    {
        static double dolarAPesos = 76.06;
        static double pesoAdolares = 0.013;
        private RepositorioBanca iContenedor = new RepositorioBanca();

        public FachadaImp(RepositorioBanca pContenedor) { this.iContenedor = pContenedor; }

        /// <summary>
        /// Imprime el menu principal
        /// </summary>
        public void MostrarPantallaPrincipal()
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1.Operar con una cuenta existente");
            Console.WriteLine("2.Crear una cuenta nueva");
            Console.WriteLine("");
            Console.WriteLine("0.Salir");
        }

        /// <summary>
        /// Crea un objeto de tipo Banca, comprobando que el titular no posea ya una cuenta y que
        /// los datos ingresados sean correctos
        /// </summary>
        public void CrearCuenta()
        {
            Console.Clear();
            Console.Write("Nombre del titular (Nombre y Apellido): " + '\n');
            String titular = Console.ReadLine();
            Console.Write("Numero de documento: " + '\n');
            String numero = Console.ReadLine();
            Console.WriteLine("");
            Banca banca = new Banca(numero, titular);
            if (iContenedor.Obtener(numero) == null && !(titular.Equals("")))
            {
                if ((Convert.ToInt32(numero) >= 1000000) && (Convert.ToInt32(numero) <= 100000000))
                {
                    iContenedor.Agregar(banca);
                    Console.WriteLine("La cuenta fue creada con exito");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Datos incorrectos. Intentelo nuevamente");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("La cuenta ya existe o falta ingresar un nombre. Intentelo nuevamente");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Solicita un ingreso para ser utilizado en un menu
        /// </summary>
        /// <returns>Devuelve un entero</returns>
        public int PedirOpcion()
        {
            return (Convert.ToInt16(Console.ReadLine()));
        }

        /// <summary>
        /// Busca una banca del repositorio
        /// </summary>
        /// <returns>Devuelve un objeto Banca si existe en el repositorio, sino devuelve null</returns>
        public Banca BuscarBanca()
        {
            Console.Clear();
            Console.Write("Ingrese la clave de su cuenta: ");
            String numero = Console.ReadLine();
            Banca banca = iContenedor.Obtener(numero);
            if (banca != null)
            {
                return banca;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("La clave ingresada no pertenece a un cliente existente");
                Console.ReadKey();
                return banca;
            }
        }

        /// <summary>
        /// Imprime el menu para seleccionar el tipo de cuenta
        /// </summary>
        /// <param name="pBanca">Banca que contiene las cuentas</param>
        public void MenuSeleccionCuenta(Banca pBanca)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido " + pBanca.Titular + '\n' + '\n');
            Console.WriteLine("Seleccione la cuenta a operar" + '\n' + '\n');
            Console.WriteLine("1.Cuenta en pesos argentinos");
            Console.WriteLine("2.Cuenta en dolares estadounidenses" + '\n' + '\n');
            Console.WriteLine("0.Salir");
        }

        /// <summary>
        /// Imprime el menu para las operaciones en pesos
        /// </summary>
        public void MenuOperacionesPesoArgentino()
        {
            Console.WriteLine("Seleccione la operacion a realizar" + '\n' + '\n');
            Console.WriteLine("1.Acreditar saldo");
            Console.WriteLine("2.Debitar saldo");
            Console.WriteLine("3.Transferir saldo a la cuenta en dolares");
            Console.WriteLine("4.Consultar saldo" + '\n' + '\n');
            Console.WriteLine("0.Salir");
        }

        /// <summary>
        /// Imprime el menu para las operaciones en dolares
        /// </summary>
        public void MenuOperacionesDolarEstadounidense()
        {
            Console.WriteLine("Seleccione la operacion a realizar" + '\n' + '\n');
            Console.WriteLine("1.Acreditar saldo");
            Console.WriteLine("2.Debitar saldo");
            Console.WriteLine("3.Transferir saldo a la cuenta en pesos");
            Console.WriteLine("4.Consultar saldo" + '\n' + '\n');
            Console.WriteLine("0.Salir");
        }

        /// <summary>
        /// Guarda los cambios realizados en una Banca en el repositorio
        /// </summary>
        /// <param name="pBanca">Banca modificada</param>
        public void GuardarCambios(Banca pBanca)
        {
            iContenedor.Agregar(pBanca);
        }

        /// <summary>
        /// Agrega un monto al saldo actual de la cuenta
        /// </summary>
        /// <param name="pCuenta">Cuenta donde acreditaremos un monto</param>
        public void AcreditarSaldo(Cuenta pCuenta)
        {
            Console.WriteLine("Ingrese el monto a acreditar:" + '\n');
            try
            {
                double monto = Convert.ToDouble(Console.ReadLine());
                pCuenta.AcreditarSaldo(monto);
                Console.WriteLine('\n' + "Saldo acreditado");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Valor no ingresado o valor incorrecto!");
            }
            catch (MontoSaldoException)
            {
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Debita un monto al saldo actual de la cuenta
        /// </summary>
        /// <param name="pCuenta">Cuenta donde debitaremos un monto</param>
        public void DebitarSaldo(Cuenta pCuenta)
        {
            Console.WriteLine("Ingrese el monto a debitar:" + '\n');
            try
            {
                double monto = Convert.ToDouble(Console.ReadLine());
                if (pCuenta.DebitarSaldo(monto) == true)
                {
                    Console.WriteLine('\n' + "La transaccion se ha realizado exitosamente");
                }
                else Console.WriteLine('\n' + "No hay fondos suficientes");
            }           
            catch(FormatException)
            {
                Console.WriteLine("Error: Valor no ingresado o valor incorrecto!");
            }
            catch(MontoSaldoException)
            {
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra el saldo de la cuenta en pesos
        /// </summary>
        /// <param name="pCuenta">Cuenta en pesos</param>
        public void MostrarSaldoPesos(Cuenta pCuenta)
        {
            Console.WriteLine("Saldo: " + pCuenta.Saldo + " " + RepositorioBanca.Monedas[0].Simbolo + '\n');
        }

        /// <summary>
        /// Muestra el saldo de la cuenta en dolares
        /// </summary>
        /// <param name="pCuenta">Cuenta en dolares</param>
        public void MostrarSaldoDolares(Cuenta pCuenta)
        {
            Console.WriteLine("Saldo: " + pCuenta.Saldo + " " + RepositorioBanca.Monedas[1].Simbolo + '\n');
        }

        /// <summary>
        /// Debita saldo de la cuenta en pesos y acredita su equivalente a la cuenta en dolares
        /// </summary>
        /// <param name="pBanca">Banca que contiene las cuentas en pesos y dolares</param>
        public void TransferirPesosADolares(Banca pBanca)
        {
            Console.WriteLine("Transferencia peso a dolar");
            Console.WriteLine("Saldo en pesos: " + pBanca.CuentaEnPesos.Saldo + " " + RepositorioBanca.Monedas[0].Simbolo);
            Console.WriteLine("Saldo en dolares: " + pBanca.CuentaEnDolares.Saldo + " " + RepositorioBanca.Monedas[1].Simbolo + '\n');
            Console.Write("Ingrese el monto a transferir: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            if (pBanca.CuentaEnPesos.DebitarSaldo(monto) == true)
            {
                double cambio = monto * pesoAdolares;
                pBanca.CuentaEnDolares.AcreditarSaldo(cambio);
                Console.WriteLine("La transferencia se ha realizado con exito");
            }
            else Console.WriteLine("El monto disponible no es suficiente");
            Console.ReadKey();
        }

        /// <summary>
        /// Debita saldo de la cuenta en dolares y acredita su equivalente a la cuenta en pesos
        /// </summary>
        /// <param name="pBanca"></param>
        public void TransferirDolaresAPesos(Banca pBanca)
        {
            Console.WriteLine("Transferencia dolar a peso");
            Console.WriteLine("Saldo en pesos: " + pBanca.CuentaEnPesos.Saldo + " " + RepositorioBanca.Monedas[0].Simbolo);
            Console.WriteLine("Saldo en dolares: " + pBanca.CuentaEnDolares.Saldo + " " + RepositorioBanca.Monedas[1].Simbolo + '\n');
            Console.Write("Ingrese el monto a transferir: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            if (pBanca.CuentaEnDolares.DebitarSaldo(monto) == true)
            {
                double cambio = monto * dolarAPesos;
                pBanca.CuentaEnPesos.AcreditarSaldo(cambio);
                Console.WriteLine('\n' + "La transferencia se ha realizado con exito");
            }
            else Console.WriteLine('n' + "El monto disponible no es suficiente");
            Console.ReadKey();
        }
    }
}
