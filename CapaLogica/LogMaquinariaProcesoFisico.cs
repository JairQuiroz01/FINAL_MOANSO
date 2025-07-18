﻿using CapaEntidad;
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

        public void Vincular(int maquinariaID, int procesoFisicoID)
        {
            DatMaquinariaProcesoFisico.Instancia.Vincular(maquinariaID, procesoFisicoID);
        }

        public List<EntMaquinariaProcesoFisico> ListarVinculos()
        {
            return DatMaquinariaProcesoFisico.Instancia.ListarVinculos();
        }

        public void EliminarVinculo(int maquinariaID, int procesoFisicoID)
        {
            DatMaquinariaProcesoFisico.Instancia.EliminarVinculo(maquinariaID, procesoFisicoID);
        }
    }
}
