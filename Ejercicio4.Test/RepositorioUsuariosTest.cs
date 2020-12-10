using System;
using Xunit;

namespace Ejercicio4.Test
{
    public class RepositorioUsuariosTest
    {
        [Fact]
        public void Test_Agregar_NoExistente()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            Usuario usuario = new Usuario();
            usuario.Codigo = "013";
            usuario.NombreCompleto = "Juan Juan Perez";
            usuario.CorreoElectronico = "juanx2@aol.com";

            //Act
            repositorio.Agregar(usuario);
            var iLista = repositorio.ObtenerTodos();
            Usuario resultado = iLista[1];

            //Assert
            Assert.Equal(usuario.Codigo, resultado.Codigo);
        }

        [Fact]
        public void Test_Agregar_Existente()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            Usuario usuario = new Usuario();
            usuario.Codigo = "015";
            usuario.NombreCompleto = "Juan Juan Perez";
            usuario.CorreoElectronico = "juanx2@aol.com";
            String cadenaEsperada = "Jorge Gaston Rodas";

            //Act
            repositorio.Agregar(usuario);
            var iLista = repositorio.ObtenerTodos();
            Usuario resultado = iLista[1];

            //Assert
            Assert.Equal(cadenaEsperada, resultado.NombreCompleto);
        }

        [Fact]
        public void Test_Actualizar()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            var iLista = repositorio.ObtenerTodos();
            Usuario usuario = iLista[2];
            usuario.CorreoElectronico = "nuevocorreo@yahoo.com";
            String cadenaEsperada = usuario.CorreoElectronico;

            //Act          
            repositorio.Actualizar(usuario);
            iLista = repositorio.ObtenerTodos();

            //Assert
            Assert.Equal(cadenaEsperada, iLista[2].CorreoElectronico);
        }

        [Fact]
        public void Test_Eliminar()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            int cantEsperada = 2;

            //Act          
            repositorio.Eliminar("015");
            var iLista = repositorio.ObtenerTodos();

            //Assert
            Assert.Equal(cantEsperada, iLista.Count);
        }

        [Fact]
        public void Test_Obtener_Por_Codigo()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            String usuarioEsperado = "Axel Emiliano Nieto";

            //Act   
            Usuario usuario = repositorio.ObtenerPorCodigo("007");

            //Assert
            Assert.Equal(usuarioEsperado, usuario.NombreCompleto);
        }

        [Fact]
        public void Test_Ordenar_Por_Nombre()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            OrdenarPorNombre contexto = new OrdenarPorNombre();
            String nombreEsperado = "Axel Emiliano Nieto";

            //Act   
            var lista = repositorio.ObtenerOrdenadosPor(contexto);
            String resultado = lista[0].NombreCompleto;

            //Assert
            Assert.Equal(nombreEsperado, resultado);
        }

        [Fact]
        public void Test_Ordenar_Por_Nombre_Descendente()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            OrdenarPorNombreDescendente contexto = new OrdenarPorNombreDescendente();
            String nombreEsperado = "Axel Emiliano Nieto";

            //Act   
            var lista = repositorio.ObtenerOrdenadosPor(contexto);
            String resultado = lista[2].NombreCompleto;

            //Assert
            Assert.Equal(nombreEsperado, resultado);
        }

        [Fact]
        public void Test_Obtener_Por_Nombre()
        {
            //Arrange
            IRepositorioUsuarios repositorio = new RepositorioUsuarios();
            String nombreEsperado = "Axel Emiliano Nieto";

            //Act
            var usuario = repositorio.ObtenerPorNombre("Nieto");

            //Assert
            Assert.Equal(nombreEsperado, usuario.NombreCompleto);
        }
    }
}
