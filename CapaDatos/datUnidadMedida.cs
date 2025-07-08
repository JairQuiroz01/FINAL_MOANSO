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
    public class datUnidadMedida
    {
        private static readonly datUnidadMedida _instancia = new datUnidadMedida();
        public static datUnidadMedida Instancia => _instancia;

        public List<entUnidadMedida> Listar()
        {
            SqlCommand cmd = null;
            List<entUnidadMedida> lista = new List<entUnidadMedida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entUnidadMedida
                    {
                        UnidadmedidaID = Convert.ToInt32(dr["UnidadmedidaID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Abreviatura = dr["Abreviatura"].ToString()
                    });
                }
            }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        public bool Insertar(entUnidadMedida u)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Abreviatura", u.Abreviatura);
                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return ok;
        }

        public bool Editar(entUnidadMedida u)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UnidadmedidaID", u.UnidadmedidaID);
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Abreviatura", u.Abreviatura);
                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return ok;
        }

        public bool Eliminar(int id)
        {
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UnidadmedidaID", id);
                cn.Open();
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return ok;
        }
    }
}

