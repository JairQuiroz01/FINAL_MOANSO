using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logProduccion
    {
        private static readonly logProduccion _instancia = new logProduccion();
        public static logProduccion Instancia => _instancia;

        // Registrar Producción
        public void Registrar(EntProduccion prod)
        {
            datProduccion.Instancia.RegistrarProduccion(prod);
        }

        // Listar Producciones
        public List<EntProduccion> Listar()
        {
            return datProduccion.Instancia.ListarProduccionSimple();
        }
    }
}
