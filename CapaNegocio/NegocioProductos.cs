using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioProductos
    {
        private DatosProductos Producto = new DatosProductos();

        public List<Producto> Listar()
        {
            return Producto.Listar();
        }
        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Codigo del Producto incompleto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Nombre del Producto incompleto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Descripcion del Producto incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Producto.Registrar(obj, out Mensaje);

            }
        }
        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Codigo del Producto incompleto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Nombre del Producto incompleto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Descripcion del Producto incompleto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return Producto.Editar(obj, out Mensaje);

            }
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return Producto.Eliminar(obj, out Mensaje);
        }
    }
}
