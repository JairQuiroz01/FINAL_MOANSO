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

        private string connectionString = "Data Source=DESKTOP-7GTF2SO.;Initial Catalog=BD_SISTEMA_VINERIA_AR_1;Integrated Security=True;";
        private DatMaquinariaProcesoFisico() { }

        // Vincular
        public void Vincular(int maquinariaID, int procesoFisicoID)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO MaquinariaProcesoFisico (MaquinariaID, ProcesofisicoID) VALUES (@MaquinariaID, @ProcesoFisicoID)", cn);
                cmd.Parameters.AddWithValue("@MaquinariaID", maquinariaID);
                cmd.Parameters.AddWithValue("@ProcesoFisicoID", procesoFisicoID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Listar todas las vinculaciones
        public List<EntMaquinariaProcesoFisico> ListarVinculos()
        {
            var lista = new List<EntMaquinariaProcesoFisico>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MaquinariaProcesoFisico", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EntMaquinariaProcesoFisico
                    {
                        MaquinariaID = (int)dr["MaquinariaID"],
                        ProcesofisicoID = (int)dr["ProcesofisicoID"]
                    });
                }
            }
            return lista;
        }
        public void EliminarVinculo(int maquinariaID, int procesoFisicoID)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM MaquinariaProcesoFisico WHERE MaquinariaID=@MaquinariaID AND ProcesofisicoID=@ProcesoFisicoID", cn);
                cmd.Parameters.AddWithValue("@MaquinariaID", maquinariaID);
                cmd.Parameters.AddWithValue("@ProcesoFisicoID", procesoFisicoID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
