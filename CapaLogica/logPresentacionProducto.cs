using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logPresentacionProducto
    {
        // Singleton (opcional, si planeas mantener una única instancia)
        private static readonly logPresentacionProducto _instancia = new logPresentacionProducto();

        public static logPresentacionProducto Instancia
        {
            get { return _instancia; }
        }

        private readonly datPresentacionProducto datos = new datPresentacionProducto();

        // 1. Listar
        public List<EntPresentacionProducto> Listar()
        {
            return datos.Listar();
        }

        // 2. Registrar
        public void Registrar(EntPresentacionProducto obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            datos.Registrar(obj);
        }

        // 3. Modificar
        public void Modificar(EntPresentacionProducto obj)
        {
            if (obj.PresentacionProductoID <= 0)
                throw new ArgumentException("ID inválido.");
            datos.Modificar(obj);
        }

        // 4. Eliminar
        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido.");
            datos.Eliminar(id);
        }
    }
}
