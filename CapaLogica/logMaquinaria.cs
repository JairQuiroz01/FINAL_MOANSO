using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    internal class LogMaquinaria
    {
        private static readonly LogMaquinaria instancia = new LogMaquinaria();
        public static LogMaquinaria Instancia => instancia;

        public void RegistrarMaquinaria(EntMaquinaria m) => DatMaquinaria.Instancia.Registrar(m);
        public void ModificarMaquinaria(EntMaquinaria m) => DatMaquinaria.Instancia.Modificar(m);
        public void InhabilitarMaquinaria(int id) => DatMaquinaria.Instancia.Inhabilitar(id);
        public EntMaquinaria BuscarMaquinariaPorID(int id) => DatMaquinaria.Instancia.BuscarPorID(id);
        public List<EntMaquinaria> ListarMaquinaria() => DatMaquinaria.Instancia.Listar();
    }
}
