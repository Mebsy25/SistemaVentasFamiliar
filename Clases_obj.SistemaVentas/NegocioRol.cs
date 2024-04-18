using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioRol
    {
        private DatosRoles drol = new DatosRoles();

        public List<Rol> Listar()
        {
            return drol.Listar();
        }
    }
}
