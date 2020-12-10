using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ejercicio5.Test
{
    public class EvaluadorAntiguedadLaboralTest
    {
        [Fact]
        public void Test_Evaluar_Antiguedad_Aprobado()
        {
            //Arrange
            DateTime fechaNacimiento;
            String formatoFecha = "dd/MM/yyyy";
            DateTime.TryParseExact("07/01/1992", formatoFecha, null, System.Globalization.DateTimeStyles.None, out fechaNacimiento);
            DateTime fechaIngreso;
            DateTime.TryParseExact("20/05/2015", formatoFecha, null, System.Globalization.DateTimeStyles.None, out fechaIngreso);
            Empleo empleo = new Empleo(20000, fechaIngreso);
            Cliente cliente = new Cliente("Axel", "Nieto", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 95000, 24);
            IEvaluador evaluador = new EvaluadorAntiguedadLaboral(6);
            bool resultadoEsperado = true;

            //Act
            bool resultado = evaluador.EsValida(solicitud);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Test_Evaluar_Antiguedad_No_Aprobado()
        {
            //Arrange
            DateTime fechaNacimiento;
            String formatoFecha = "dd/MM/yyyy";
            DateTime.TryParseExact("07/01/1992", formatoFecha, null, System.Globalization.DateTimeStyles.None, out fechaNacimiento);
            DateTime fechaIngreso;
            DateTime.TryParseExact("20/09/2020", formatoFecha, null, System.Globalization.DateTimeStyles.None, out fechaIngreso);
            Empleo empleo = new Empleo(20000, fechaIngreso);
            Cliente cliente = new Cliente("Axel", "Nieto", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 95000, 24);
            IEvaluador evaluador = new EvaluadorAntiguedadLaboral(6);
            bool resultadoEsperado = false;

            //Act
            bool resultado = evaluador.EsValida(solicitud);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
