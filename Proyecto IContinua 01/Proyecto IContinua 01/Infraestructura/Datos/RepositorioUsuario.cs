using Proyecto_IContinua_01.Dominio.Entidades;
using Proyecto_IContinua_01.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IContinua_01.Infraestructura.Datos
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly List<Usuario> _usuarios;

        public RepositorioUsuario()
        {
            // Inicializamos con los usuarios Mario y Alex
            _usuarios = new List<Usuario>
        {
            new Usuario("Mario", "mario123"),
            new Usuario("Alex", "alex123")
        };
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            return _usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }
    }
}
