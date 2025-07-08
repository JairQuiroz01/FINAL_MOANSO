using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaLogica;


namespace CapaLogica
{
    public class logProducto
    {
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia => _instancia;

        // Listar productos
        public List<entProducto> Listar()
        {
            return datProducto.Instancia.Listar();
        }

        // Registrar producto
        public bool Insertar(entProducto p)
        {
            return datProducto.Instancia.Insertar(p);
        }

        // Modificar producto
        public bool Editar(entProducto p)
        {
            return datProducto.Instancia.Editar(p);
        }

        // Eliminar producto
        public bool Eliminar(int id)
        {
            return datProducto.Instancia.Eliminar(id);
        }

        // Buscar productos por categoría o presentación
        public List<entProducto> Buscar(string filtro)
        {
            return datProducto.Instancia.Buscar(filtro);
        }
        private void CargarCombos()
        {
            // CATEGORÍA
            cbCategoria.DataSource = logCategoriaProducto.Instancia.Listar();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "CategoriaproductoID";


            // UNIDAD DE MEDIDA
            cbUnidadMedida.DataSource = logUnidadMedida.Instancia.Listar();
            cbUnidadMedida.DisplayMember = "Nombre";
            cbUnidadMedida.ValueMember = "UnidadmedidaID";
        }
    }
}
