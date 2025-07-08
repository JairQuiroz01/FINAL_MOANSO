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
    public class DatProcesoF
    {
        private static readonly DatProcesoF instancia = new DatProcesoF();
        public static DatProcesoF Instancia => instancia;

        private readonly string connectionString = "TU_CONEXION";

        public void Registrar(EntProcesoF p)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("RegistrarProcesoFisico", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", p.Duracion);
                cmd.Parameters.AddWithValue("@EstadoProcesoFisico", p.EstadoProcesoFisico);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modificar(EntProcesoF p)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("ModificarProcesoFisico", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProcesofisicoID", p.ProcesofisicoID);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", p.Duracion);
                cmd.Parameters.AddWithValue("@EstadoProcesoFisico", p.EstadoProcesoFisico);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Inhabilitar(int id)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("InhabilitarProcesoFisico", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProcesofisicoID", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public EntProcesoF BuscarPorID(int id)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("BuscarProcesoFisicoPorID", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProcesofisicoID", id);
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new EntProcesoF
                        {
                            ProcesofisicoID = (int)dr["ProcesofisicoID"],
                            Nombre = dr["Nombre"].ToString(),
                            Duracion = dr["Duracion"].ToString(),
                            EstadoProcesoFisico = (bool)dr["EstadoProcesoFisico"]
                        };
                    }
                }
            }
            return null;
        }

        public List<EntProcesoF> Listar()
        {
            var lista = new List<EntProcesoF>();
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("ListarProcesoFisico", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EntProcesoF
                        {
                            ProcesofisicoID = (int)dr["ProcesofisicoID"],
                            Nombre = dr["Nombre"].ToString(),
                            Duracion = dr["Duracion"].ToString(),
                            EstadoProcesoFisico = (bool)dr["EstadoProcesoFisico"]
                        });
                    }
                }
            }
            return lista;
        }
    }
}
