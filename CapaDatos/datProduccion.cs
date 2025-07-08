using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datProduccion
    {
        // Singleton
        private static readonly datProduccion _instancia = new datProduccion();
        public static datProduccion Instancia => _instancia;

        // Registrar Producción
        public void RegistrarProduccion(EntProduccion prod)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarProduccion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProcesofisicoID", prod.ProcesofisicoID);
                cmd.Parameters.AddWithValue("@ProductosID", prod.ProductosID);
                cmd.Parameters.AddWithValue("@MaquinariaID", prod.MaquinariaID);
                cmd.Parameters.AddWithValue("@CantidadProducir", prod.CantidadProducir);
                cmd.Parameters.AddWithValue("@FechaInicio", prod.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", prod.FechaFin);
                cmd.Parameters.AddWithValue("@Estado", prod.Estado);
                cmd.Parameters.AddWithValue("@Observaciones", prod.Observaciones);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Listar Producción (modo simple)
        public List<EntProduccion> ListarProduccionSimple()
        {
            var lista = new List<EntProduccion>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarProduccionSimple", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EntProduccion
                        {
                            DetalleProduccionID = (int)dr["DetalleProduccionID"],
                            ProcesofisicoID = (int)dr["ProcesofisicoID"],
                            ProductosID = (int)dr["ProductosID"],
                            MaquinariaID = (int)dr["MaquinariaID"],
                            CantidadProducir = (int)dr["CantidadProducir"],
                            FechaInicio = (DateTime)dr["FechaInicio"],
                            FechaFin = (DateTime)dr["FechaFin"],
                            Estado = dr["Estado"].ToString(),
                            Observaciones = dr["Observaciones"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}
