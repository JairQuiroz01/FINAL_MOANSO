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
    public class DatMaquinariaProcesoFisico
    {
        private static readonly DatMaquinariaProcesoFisico _instancia = new DatMaquinariaProcesoFisico();
        public static DatMaquinariaProcesoFisico Instancia => _instancia;

        private string connectionString = "JUNITHOR";  // ⚠️ Ajusta tu cadena

        private DatMaquinariaProcesoFisico() { }

        // Vincular
        public void Vincular(int maquinariaID, int procesoFisicoID)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("VincularMaquinariaProcesoFisico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaquinariaID", maquinariaID);
                cmd.Parameters.AddWithValue("@ProcesofisicoID", procesoFisicoID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Listar todas las vinculaciones
        public List<EntMaquinariaProcesoFisico> ListarVinculos()
        {
            List<EntMaquinariaProcesoFisico> lista = new List<EntMaquinariaProcesoFisico>();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ListarMaquinariaProcesoFisico", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EntMaquinariaProcesoFisico
                    {
                        MaquinariaID = (int)dr["MaquinariaID"],
                        NombreMaquinaria = dr["NombreMaquinaria"].ToString(),
                        Marca = dr["Marca"].ToString(),
                        ProcesofisicoID = (int)dr["ProcesofisicoID"],
                        NombreProceso = dr["NombreProceso"].ToString(),
                        Duracion = dr["Duracion"].ToString()
                    });
                }
            }

            return lista;
        }
        public void EliminarVinculo(int maquinariaID, int procesoFisicoID)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("EliminarVinculoMaquinariaProceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaquinariaID", maquinariaID);
                cmd.Parameters.AddWithValue("@ProcesofisicoID", procesoFisicoID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
