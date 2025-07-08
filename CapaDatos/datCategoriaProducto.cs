using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datCategoriaProducto
    {
        private static readonly datCategoriaProducto _instancia = new datCategoriaProducto();
        public static datCategoriaProducto Instancia => _instancia;

        public List<entCategoriaProducto> Listar()
        {
            SqlCommand cmd = null;
            List<entCategoriaProducto> lista = new List<entCategoriaProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoriaProducto cat = new entCategoriaProducto
                    {
                        CategoriaProductoID = Convert.ToInt32(dr["CategoriaProductoID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    };
                    lista.Add(cat);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public bool Insertar(entCategoriaProducto c)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
                cn.Open();
                inserta = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public bool Editar(entCategoriaProducto c)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaProductoID", c.CategoriaProductoID);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
                cn.Open();
                edita = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public bool Eliminar(int id)
        {
            SqlCommand cmd = null;
            bool elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaProductoID", id);
                cn.Open();
                elimina = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
    }
}
