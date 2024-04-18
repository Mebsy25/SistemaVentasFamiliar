using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioPermiso
    {
        private Permisos Permiso = new Permisos();

        public List<Permiso> Listar(int IdUsuario)
        {
            return Permiso.Listar(IdUsuario);
        }
    }
}
