using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DatMaquinaria
    {
        private static readonly DatMaquinaria instancia = new DatMaquinaria();
        public static DatMaquinaria Instancia => instancia;

        private readonly string connectionString = "JUNITHOR";

        public void RegistrarMaquinaria(EntMaquinaria m)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("RegistrarMaquinaria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@Marca", m.Marca);
                cmd.Parameters.AddWithValue("@EstadoMaquinaria", m.EstadoMaquinaria);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarMaquinaria(EntMaquinaria m)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("ModificarMaquinaria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaquinariaID", m.MaquinariaID);
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@Marca", m.Marca);
                cmd.Parameters.AddWithValue("@EstadoMaquinaria", m.EstadoMaquinaria);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InhabilitarMaquinaria(int id)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("InhabilitarMaquinaria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaquinariaID", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public EntMaquinaria BuscarMaquinariaPorID(int id)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("BuscarMaquinariaPorID", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaquinariaID", id);
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new EntMaquinaria
                        {
                            MaquinariaID = (int)dr["MaquinariaID"],
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            EstadoMaquinaria = (bool)dr["EstadoMaquinaria"]
                        };
                    }
                }
            }
            return null;
        }

        public List<EntMaquinaria> ListarMaquinaria()
        {
            var lista = new List<EntMaquinaria>();
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("ListarMaquinaria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EntMaquinaria
                        {
                            MaquinariaID = (int)dr["MaquinariaID"],
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            EstadoMaquinaria = (bool)dr["EstadoMaquinaria"]
                        });
                    }
                }
            }
            return lista;
        }
        // En DatMaquinaria.cs
        public List<EntMaquinaria> ListarMaquinarias()
        {
            var lista = new List<EntMaquinaria>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT MaquinariaID, Nombre FROM Maquinaria WHERE EstadoMaquinaria = 1", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EntMaquinaria
                    {
                        MaquinariaID = (int)dr["MaquinariaID"],
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
