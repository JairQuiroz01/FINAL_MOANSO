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
        private static readonly LogProcesoF instancia = new LogProcesoF();
        public static LogProcesoF Instancia => instancia;

        public void RegistrarProcesoFisico(EntProcesoF p) => DatProcesoF.Instancia.Registrar(p);
        public void ModificarProcesoFisico(EntProcesoF p) => DatProcesoF.Instancia.Modificar(p);
        public void InhabilitarProcesoFisico(int id) => DatProcesoF.Instancia.Inhabilitar(id);
        public EntProcesoF BuscarProcesoFisicoPorID(int id) => DatProcesoF.Instancia.BuscarPorID(id);
        public List<EntProcesoF> ListarProcesoFisico() => DatProcesoF.Instancia.Listar();
    }
}
