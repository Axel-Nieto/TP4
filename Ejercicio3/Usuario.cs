using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Usuario: IComparable<Usuario>
    {
        private String iCodigo;
        private String iNombreCompleto;
        private String iCorreoElectronico;

        public String Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }
        public String NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { this.iNombreCompleto = value; }
        }
        public String CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { this.iCorreoElectronico = value; }
        }

        public int CompareTo(Usuario otroUsuario)
        {
            var numero = Convert.ToInt32(this.Codigo);
            var otroNumero = Convert.ToInt32(otroUsuario.Codigo);
            if (numero < otroNumero) return -1;
            else if (numero > otroNumero) return 1;
            else return 0;
        }
    }
}
