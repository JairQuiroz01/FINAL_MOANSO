using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class LogMaquinariaProcesoFisico
    {
        private static readonly LogMaquinariaProcesoFisico _instancia = new LogMaquinariaProcesoFisico();
        public static LogMaquinariaProcesoFisico Instancia => _instancia;

        private LogMaquinariaProcesoFisico() { }

        public void Vincular(int maquinariaID, int procesoFisicoID)
        {
            DatMaquinariaProcesoFisico.Instancia.Vincular(maquinariaID, procesoFisicoID);
        }

        public List<EntMaquinariaProcesoFisico> Listar()
        {
            return DatMaquinariaProcesoFisico.Instancia.Listar();
        }
    }
}
