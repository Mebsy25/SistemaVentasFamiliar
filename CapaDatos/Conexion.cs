using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static string ConnectionString
        {
            get
            {
                return @"Server=.\SQLEXPRESS;Database=SistemaVentasPapa;Integrated Security=True;TrustServerCertificate=True";
            }
        }

    }
}
