using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datProducto
    {
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia => _instancia;

        // LISTAR
        public List<entProducto> Listar()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entProducto
                    {
                        ProductosID = Convert.ToInt32(dr["ProductosID"]),
                        CategoriaproductoID = Convert.ToInt32(dr["CategoriaproductoID"]),
                        PresentacionproductoID = Convert.ToInt32(dr["PresentacionproductoID"]),
                        UnidadmedidaID = Convert.ToInt32(dr["UnidadmedidaID"]),
                        CategoriaNombre = dr["CategoriaNombre"].ToString(),
                        PresentacionNombre = dr["PresentacionNombre"].ToString(),
                        UnidadNombre = dr["UnidadNombre"].ToString()
                    });
                }
            }
            finally { if (cmd?.Connection?.State == ConnectionState.Open) cmd.Connection.Close(); }
            return lista;
        }

        // INSERTAR
        public bool Insertar(entProducto p)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_RegistrarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", p.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@PresentacionID", p.PresentacionproductoID);
                cmd.Parameters.AddWithValue("@UnidadID", p.UnidadmedidaID);
                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                inserta = filas > 0;
            }
            finally { if (cmd?.Connection?.State == ConnectionState.Open) cmd.Connection.Close(); }
            return inserta;
        }

        // EDITAR
        public bool Editar(entProducto p)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", p.ProductosID);
                cmd.Parameters.AddWithValue("@CategoriaID", p.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@PresentacionID", p.PresentacionproductoID);
                cmd.Parameters.AddWithValue("@UnidadID", p.UnidadmedidaID);
                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                edita = filas > 0;
            }
            finally { if (cmd?.Connection?.State == ConnectionState.Open) cmd.Connection.Close(); }
            return edita;
        }

        // ELIMINAR
        public bool Eliminar(int id)
        {
            SqlCommand cmd = null;
            bool elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_EliminarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                elimina = filas > 0;
            }
            finally { if (cmd?.Connection?.State == ConnectionState.Open) cmd.Connection.Close(); }
            return elimina;
        }

        // BUSCAR
        public List<entProducto> Buscar(string filtro)
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_BuscarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Busqueda", filtro);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entProducto
                    {
                        ProductosID = Convert.ToInt32(dr["ProductosID"]),
                        CategoriaproductoID = Convert.ToInt32(dr["CategoriaproductoID"]),
                        PresentacionproductoID = Convert.ToInt32(dr["PresentacionproductoID"]),
                        UnidadmedidaID = Convert.ToInt32(dr["UnidadmedidaID"]),
                        CategoriaNombre = dr["CategoriaNombre"].ToString(),
                        PresentacionNombre = dr["PresentacionNombre"].ToString(),
                        UnidadNombre = dr["UnidadNombre"].ToString()
                    });
                }
            }
            finally { if (cmd?.Connection?.State == ConnectionState.Open) cmd.Connection.Close(); }
            return lista;
        }
    }
}
