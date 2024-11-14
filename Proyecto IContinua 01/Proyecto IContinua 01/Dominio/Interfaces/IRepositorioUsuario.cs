using Proyecto_IContinua_01.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IContinua_01.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        Usuario ObtenerUsuarioPorNombre(string nombreUsuario);
    }

}
