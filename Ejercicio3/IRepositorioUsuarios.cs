using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public interface IRepositorioUsuarios
    {
        public void Agregar(Usuario pUsuario);
        public void Actualizar(Usuario pUsuario);
        public void Eliminar(String pCodigo);
        public List<Usuario> ObtenerTodos();
        public Usuario ObtenerPorCodigo(String pCodigo);
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
    }
}
