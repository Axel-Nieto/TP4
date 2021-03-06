﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class RepositorioUsuarios: IRepositorioUsuarios
    {
        private List<Usuario> iLista;

        public RepositorioUsuarios()
        {
            this.iLista = new List<Usuario>();

            Usuario usuario = new Usuario();
            usuario.Codigo = "028";
            usuario.NombreCompleto = "Nicolas Emiliano Olivera";
            usuario.CorreoElectronico = "nicoolivera717@gmail.com";
            Agregar(usuario);

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "007";
            usuario2.NombreCompleto = "Axel Emiliano Nieto";
            usuario2.CorreoElectronico = "axelnieto616@gmail.com";
            Agregar(usuario2);

            Usuario usuario3 = new Usuario();
            usuario3.Codigo = "015";
            usuario3.NombreCompleto = "Jorge Gaston Rodas";
            usuario3.CorreoElectronico = "jorgerodas818@outlook.com";
            Agregar(usuario3);
        }

        private String GenerarCodigo()
        {
            Random random = new Random();
            bool generado = false;
            int codigo;
            String cadena = "";
            do
            {
                codigo = random.Next(1, 101);
                foreach (Usuario usuario in iLista)
                {
                    if (usuario.Codigo == Convert.ToString(codigo))
                    {
                        break;                        
                    }else if (usuario.Codigo == iLista[iLista.Count-1].Codigo)
                    {
                        generado = true;
                        if (codigo < 10)
                        {
                            cadena = "00" + Convert.ToString(codigo);
                        }
                        else if (codigo < 100)
                        {
                            cadena = "0" + Convert.ToString(codigo);
                        }
                        else { cadena = Convert.ToString(codigo); }
                    }
                }                
            } while (generado == false);
            return cadena;
        }

        public void Agregar(Usuario pUsuario)
        {
            if (iLista.Contains(pUsuario) == false)
            {
                iLista.Add(pUsuario);
                iLista.Sort();
            }
        }

        public void Actualizar(Usuario pUsuario)
        {
            //Reemplazamos el objeto de la lista, manteniendo el orden segun el codigo
            int contador = 0;
            foreach (Usuario usuario in iLista)
            {
                if (usuario.Codigo == pUsuario.Codigo)
                {
                    iLista[contador].NombreCompleto = pUsuario.NombreCompleto;
                    iLista[contador].CorreoElectronico = pUsuario.CorreoElectronico;
                    break;
                }
                else contador++;
            }
        }

        public void Eliminar(String pCodigo)
        {
            int contador = 0;
            foreach (Usuario usuario in iLista)
            {
                if (usuario.Codigo == pCodigo)
                {
                    iLista.RemoveAt(contador);
                    break;
                }
                else contador++;
            }
        }

        public List<Usuario> ObtenerTodos()
        {
            return iLista;
        }

        public Usuario ObtenerPorCodigo(String pCodigo)
        {
            foreach (Usuario usuario in iLista)
            {
                if (usuario.Codigo == pCodigo)
                {
                    return usuario;
                }
            }
            return null;
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pContexto)
        {
            iLista.Sort(pContexto);
            return iLista;
        }

        public Usuario ObtenerPorNombre(String pSubcadena)
        {
            List<Usuario> lista = new List<Usuario>(iLista);            
            foreach (Usuario usuario in lista)
            {
                if (usuario.NombreCompleto.IndexOf(pSubcadena) != -1)
                {
                    Usuario resultado = new Usuario();
                    resultado.Codigo = usuario.Codigo;
                    resultado.NombreCompleto = usuario.NombreCompleto;
                    resultado.CorreoElectronico = usuario.CorreoElectronico;
                    return resultado;                   
                }
            }
            return null;
        }
    }
}
