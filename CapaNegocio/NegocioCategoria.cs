using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioCategoria
    {
        private DatosCategoria Categoria = new DatosCategoria();

        public List<Categoria> Listar()
        {
            return Categoria.Listar();
        }
        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Descripcion == "")
            {
                Mensaje += "Descripcion incompleta\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Categoria.Registrar(obj, out Mensaje);

            }
        }
        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Descripcion == "")
            {
                Mensaje += "Descripcion incompleta\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return Categoria.Editar(obj, out Mensaje);

            }
        }
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
