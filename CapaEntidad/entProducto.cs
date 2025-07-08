using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class entProducto
    {
        public int ProductosID { get; set; }
        public int CategoriaproductoID { get; set; }
        public int PresentacionproductoID { get; set; }
        public int UnidadmedidaID { get; set; }

        public string CategoriaNombre { get; set; }
        public string PresentacionNombre { get; set; }
        public string UnidadNombre { get; set; }
    }
}
