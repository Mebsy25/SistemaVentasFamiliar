using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioProveedor
    {

        private DatosProveedor Proveedor = new DatosProveedor();

        public List<Proveedor> Listar()
        {
            return Proveedor.Listar();
        }
        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Documento del Proveedor incompleto\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "RazonSocial del Proveedor incompleto\n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Email del Proveedor incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Proveedor.Registrar(obj, out Mensaje);

            }
        }
        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Documento del Proveedor incompleto\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "RazonSocial del Proveedor incompleto\n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Email del Proveedor incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return Proveedor.Editar(obj, out Mensaje);

            }
        }
        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}

