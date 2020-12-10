using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioBanca repo = new RepositorioBanca();
            IFachada fachada = new FachadaImp(repo);
            int opcion;
            int opcion2;
            int opcion3;
            do
            {
                fachada.MostrarPantallaPrincipal();
                opcion = fachada.PedirOpcion();
                switch (opcion)
                {
                    case 1:
                        Banca banca = fachada.BuscarBanca();
                        if (banca != null)
                        {
                            do
                            {
                                fachada.MenuSeleccionCuenta(banca);
                                opcion2 = fachada.PedirOpcion();
                                switch (opcion2)
                                {
                                    case 1:
                                        Console.Clear();
                                        fachada.MenuOperacionesPesoArgentino();
                                        opcion3 = fachada.PedirOpcion();
                                        switch (opcion3)
                                        {
                                            case 1:
                                                Console.Clear();
                                                fachada.MostrarSaldoPesos(banca.CuentaEnPesos);
                                                fachada.AcreditarSaldo(banca.CuentaEnPesos);
                                                break;
                                            case 2:
                                                Console.Clear();
                                                fachada.MostrarSaldoPesos(banca.CuentaEnPesos);
                                                fachada.DebitarSaldo(banca.CuentaEnPesos);
                                                break;
                                            case 3:
                                                Console.Clear();
                                                fachada.TransferirPesosADolares(banca);
                                                break;
                                            case 4:
                                                Console.Clear();
                                                fachada.MostrarSaldoPesos(banca.CuentaEnPesos);
                                                Console.ReadKey();
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                        fachada.MenuOperacionesDolarEstadounidense();
                                        opcion3 = fachada.PedirOpcion();
                                        switch (opcion3)
                                        {
                                            case 1:
                                                Console.Clear();
                                                fachada.MostrarSaldoDolares(banca.CuentaEnDolares);
                                                fachada.AcreditarSaldo(banca.CuentaEnDolares);
                                                break;
                                            case 2:
                                                Console.Clear();
                                                fachada.MostrarSaldoDolares(banca.CuentaEnDolares);
                                                fachada.DebitarSaldo(banca.CuentaEnDolares);
                                                break;
                                            case 3:
                                                Console.Clear();
                                                fachada.TransferirDolaresAPesos(banca);
                                                break;
                                            case 4:
                                                Console.Clear();
                                                fachada.MostrarSaldoDolares(banca.CuentaEnDolares);
                                                Console.ReadKey();
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (opcion2 != 0);
                            fachada.GuardarCambios(banca);
                        }
                        break;
                    case 2:
                        fachada.CrearCuenta();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
    }
}
