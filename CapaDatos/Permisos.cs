using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class Permisos
    {
        public List<Permiso> Listar(int idusuario)
        {

            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection connection = new SqlConnection(Conexion.ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT p.IdRol, p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO U on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(reader["IdRol"]) },
                                NombreMenu = reader["NombreMenu"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
