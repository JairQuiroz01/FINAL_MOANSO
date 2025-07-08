using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datProduccion
    {
        // REGISTRAR producción
        public void Registrar(EntProduccion obj)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarProduccion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProcesofisicoID", obj.ProcesofisicoID);
                cmd.Parameters.AddWithValue("@ProductosID", obj.ProductosID);
                cmd.Parameters.AddWithValue("@MaquinariaID", obj.MaquinariaID);
                cmd.Parameters.AddWithValue("@CantidadProducir", obj.CantidadProducir);
                cmd.Parameters.AddWithValue("@FechaInicio", obj.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", obj.FechaFin);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@Observaciones", obj.Observaciones);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // LISTAR producciones (sin orden)
        public List<EntProduccion> Listar()
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
                            DetalleProduccionID = Convert.ToInt32(dr["DetalleProduccionID"]),
                            ProcesofisicoID = Convert.ToInt32(dr["ProcesofisicoID"]),
                            ProductosID = Convert.ToInt32(dr["ProductosID"]),
                            MaquinariaID = Convert.ToInt32(dr["MaquinariaID"]),
                            CantidadProducir = Convert.ToInt32(dr["CantidadProducir"]),
                            FechaInicio = Convert.ToDateTime(dr["FechaInicio"]),
                            FechaFin = Convert.ToDateTime(dr["FechaFin"]),
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
