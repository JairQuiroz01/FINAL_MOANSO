using System;

namespace CapaEntidad
{
    public class EntProduccion
    {
        public int DetalleProduccionID { get; set; }
        public int ProcesofisicoID { get; set; }
        public int ProductosID { get; set; }
        public int MaquinariaID { get; set; }
        public int CantidadProducir { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }

        // Extras para mostrar nombres en el DataGridView (no obligatorios en la BD)
        public string NombreProceso { get; set; }
        public string NombreProducto { get; set; }
        public string NombreMaquinaria { get; set; }
    }
}
