using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUnidadMedida
    {
        private static readonly logUnidadMedida _instancia = new logUnidadMedida();
        public static logUnidadMedida Instancia => _instancia;

        public List<entUnidadMedida> Listar() => datUnidadMedida.Instancia.Listar();
        public void Insertar(entUnidadMedida u) => datUnidadMedida.Instancia.Insertar(u);
        public void Editar(entUnidadMedida u) => datUnidadMedida.Instancia.Editar(u);
        public void Eliminar(int id) => datUnidadMedida.Instancia.Eliminar(id);
    }
}
