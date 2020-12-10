using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class GestorPrestamos
    {
        private Dictionary<TipoCliente,EvaluadorCompuesto> iEvaluadoresPorCliente= new Dictionary<TipoCliente,EvaluadorCompuesto>();
        
        public GestorPrestamos()
        {
            //Crear un evaluador compuesto (que se ira modificando de acuerdo al tipo de cliente)
            EvaluadorCompuesto evaluador = new EvaluadorCompuesto();

            //Crear los evaluadores para los valores minimos de sueldo, edad y antigüedad
            EvaluadorAntiguedadLaboral evaluadorAntiguedad = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo evaluadorSueldo = new EvaluadorSueldo(5000);

            //Evaluadores de No-Clientes
            evaluador.AgregarEvaluador(evaluadorAntiguedad);
            evaluador.AgregarEvaluador(evaluadorEdad);
            evaluador.AgregarEvaluador(evaluadorSueldo);
            evaluador.AgregarEvaluador(new EvaluadorMonto(20000));
            evaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(12));
            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, evaluador);

            evaluador = new EvaluadorCompuesto();

            //Evaluadores de Clientes
            evaluador.AgregarEvaluador(evaluadorAntiguedad);
            evaluador.AgregarEvaluador(evaluadorEdad);
            evaluador.AgregarEvaluador(evaluadorSueldo);
            evaluador.AgregarEvaluador(new EvaluadorMonto(100000));
            evaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(32));
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, evaluador);

            evaluador = new EvaluadorCompuesto();

            //Evaluadores de Clientes Gold
            evaluador.AgregarEvaluador(evaluadorAntiguedad);
            evaluador.AgregarEvaluador(evaluadorEdad);
            evaluador.AgregarEvaluador(evaluadorSueldo);
            evaluador.AgregarEvaluador(new EvaluadorMonto(150000));
            evaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, evaluador);

            evaluador = new EvaluadorCompuesto();

            //Evaluadores de Clientes Platinum
            evaluador.AgregarEvaluador(evaluadorAntiguedad);
            evaluador.AgregarEvaluador(evaluadorEdad);
            evaluador.AgregarEvaluador(evaluadorSueldo);
            evaluador.AgregarEvaluador(new EvaluadorMonto(200000));
            evaluador.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, evaluador);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
