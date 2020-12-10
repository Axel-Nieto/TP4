using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public interface IFachada
    {

        public void MostrarPantallaPrincipal();

        public void CrearCuenta();

        public int PedirOpcion();

        public Banca BuscarBanca();

        public void MenuSeleccionCuenta(Banca pBanca);

        public void MenuOperacionesPesoArgentino();

        public void MenuOperacionesDolarEstadounidense();

        public void GuardarCambios(Banca pBanca);

        public void AcreditarSaldo(Cuenta pCuenta);    

        public void DebitarSaldo(Cuenta pCuenta);

        public void MostrarSaldoPesos(Cuenta pCuenta);

        public void MostrarSaldoDolares(Cuenta pCuenta);

        public void TransferirPesosADolares(Banca pBanca);

        public void TransferirDolaresAPesos(Banca pBanca);
    }
}
