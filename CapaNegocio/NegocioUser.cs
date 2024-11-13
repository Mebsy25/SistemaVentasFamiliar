using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioUser
    {
        private DatosUsuario Usuario = new DatosUsuario();

        public List<Usuario> Listar()
        {
            return Usuario.Listar();
        }
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if(obj.Documento == "")
            {
                Mensaje += "Documento del Usuario incompleto\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Nombre del Usuario incompleto\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Clave del Usuario incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Usuario.Registrar(obj, out Mensaje);

            }
        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Documento del Usuario incompleto\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Nombre del Usuario incompleto\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Clave del Usuario incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return Usuario.Editar(obj, out Mensaje);

            }
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return Usuario.Eliminar(obj, out Mensaje);
        }
    }
}
