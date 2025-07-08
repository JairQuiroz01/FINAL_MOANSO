using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogMaquinaria
    {
        private static readonly LogMaquinaria _instancia = new LogMaquinaria();
        public static LogMaquinaria Instancia => _instancia;
        private DatMaquinaria dat = new DatMaquinaria();

        private LogMaquinaria() { }

        // REGISTRAR
        public void RegistrarMaquinaria(EntMaquinaria entidad)
        {
            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(entidad.Marca))
                throw new Exception("La marca es obligatoria.");

            dat.RegistrarMaquinaria(entidad);
        }

        // MODIFICAR
        public void ModificarMaquinaria(EntMaquinaria entidad)
        {
            if (entidad.MaquinariaID <= 0)
                throw new Exception("El ID debe ser mayor que cero.");

            dat.ModificarMaquinaria(entidad);
        }

        // INHABILITAR
        public void InhabilitarMaquinaria(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            dat.InhabilitarMaquinaria(id);
        }

        // LISTAR
        public List<EntMaquinaria> ListarMaquinaria()
        {
            return dat.ListarMaquinaria();
        }

        // BUSCAR POR ID
        public EntMaquinaria BuscarMaquinariaPorID(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            return dat.BuscarMaquinariaPorID(id);
        }
        public List<EntMaquinaria> ListarMaquinariaActiva()
        {
            return DatMaquinaria.Instancia.ListarMaquinariaActiva();
        }
    }
}
