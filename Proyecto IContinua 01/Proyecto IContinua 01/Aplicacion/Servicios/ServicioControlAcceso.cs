using Proyecto_IContinua_01.Dominio.Entidades;
using Proyecto_IContinua_01.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IContinua_01.Aplicacion.Servicios
{
    public class ServicioControlAcceso
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public ServicioControlAcceso(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public bool Autenticar(string nombreUsuario, string contrasena)
        {
            Usuario usuario = _repositorioUsuario.ObtenerUsuarioPorNombre(nombreUsuario);
            return usuario != null && usuario.Contrasena == contrasena;
        }
    }
}
