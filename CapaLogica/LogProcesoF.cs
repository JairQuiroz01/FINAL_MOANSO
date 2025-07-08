using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class LogProcesoF
    {
        private static readonly LogProcesoF _instancia = new LogProcesoF();
        public static LogProcesoF Instancia => _instancia;

        public void RegistrarProcesoFisico(EntProcesoF proceso)
        {
            DatProcesoF.Instancia.RegistrarProcesoFisico(proceso);
        }

        public void ModificarProcesoFisico(EntProcesoF proceso)
        {
            if (proceso.ProcesofisicoID <= 0)
                throw new Exception("ID inválido para modificar.");
            DatProcesoF.Instancia.ModificarProcesoFisico(proceso);
        }

        public void InhabilitarProcesoFisico(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para inhabilitar.");
            DatProcesoF.Instancia.InhabilitarProcesoFisico(id);
        }

        public List<EntProcesoF> ListarProcesoFisico()
        {
            return DatProcesoF.Instancia.ListarProcesoFisico();
        }

        public EntProcesoF BuscarProcesoFisicoPorID(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para buscar.");
            return DatProcesoF.Instancia.BuscarProcesoFisicoPorID(id);
        }
        public List<EntProcesoF> ListarProcesosActivos()
        {
            return DatProcesoF.Instancia.ListarProcesosActivos();
        }
    }
}
