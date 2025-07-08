using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datPresentacionProducto
    {
        // Listar todas las presentaciones
        public List<EntPresentacionProducto> Listar()
        {
            var lista = new List<EntPresentacionProducto>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarPresentacionProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EntPresentacionProducto
                        {
                            PresentacionProductoID = Convert.ToInt32(dr["PresentacionproductoID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        // Registrar una presentación
        public void Registrar(EntPresentacionProducto obj)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarPresentacionProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Modificar una presentación
        public void Modificar(EntPresentacionProducto obj)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ModificarPresentacionProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PresentacionproductoID", obj.PresentacionProductoID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar una presentación
        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarPresentacionProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PresentacionproductoID", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
