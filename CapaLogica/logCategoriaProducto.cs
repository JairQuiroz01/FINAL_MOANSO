using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoriaProducto
    {
        private static readonly logCategoriaProducto _instancia = new logCategoriaProducto();
        public static logCategoriaProducto Instancia => _instancia;

        public List<entCategoriaProducto> Listar() => datCategoriaProducto.Instancia.Listar();
        public void Insertar(entCategoriaProducto c) => datCategoriaProducto.Instancia.Insertar(c);
        public void Editar(entCategoriaProducto c) => datCategoriaProducto.Instancia.Editar(c);
        public void Eliminar(int id) => datCategoriaProducto.Instancia.Eliminar(id);
    }
}
