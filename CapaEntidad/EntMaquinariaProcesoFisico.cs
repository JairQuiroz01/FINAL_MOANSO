using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntMaquinariaProcesoFisico
    {
        public int MaquinariaID { get; set; }
        public string NombreMaquinaria { get; set; }
        public string Marca { get; set; }
        public int ProcesofisicoID { get; set; }
        public string NombreProceso { get; set; }
        public string Duracion { get; set; }
    }
}
