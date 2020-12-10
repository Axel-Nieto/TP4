using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFachada fachada = new Fachada();
            String respuesta="";
            do
            {
                try
                {
                    Console.Write("Ingrese el dividendo: ");
                    int dividendo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    fachada.Dividir(dividendo, divisor);
                    Console.WriteLine("");
                    Console.WriteLine("Quiere hacer otra division?");
                    respuesta = Console.ReadLine();
                }
                catch(FormatException e)
                {
                    String mensaje = "Error: " + e.Message + ". Source: " + e.Source + ". Stack Trace: " + e.StackTrace;
                    Console.WriteLine(mensaje);
                    Console.WriteLine("");
                    Console.WriteLine("Quiere hacer otra division? n/N para salir");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta != "n" && respuesta != "N") ;
        }
    }
}
