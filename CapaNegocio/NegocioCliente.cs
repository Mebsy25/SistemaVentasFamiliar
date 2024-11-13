using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioCliente
    {
        private DatosClientes Cliente = new DatosClientes();

        public List<Cliente> Listar()
        {
            return Cliente.Listar();
        }
        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Documento del Cliente incompleto\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Nombre del Cliente incompleto\n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Email del Cliente incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Cliente.Registrar(obj, out Mensaje);

            }
        }
        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Documento del Cliente incompleto\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Nombre del Cliente incompleto\n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Email del Cliente incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return Cliente.Editar(obj, out Mensaje);

            }
        }
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return Cliente.Eliminar(obj, out Mensaje);
        }
    }
}
