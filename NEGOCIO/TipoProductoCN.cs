using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class TipoProductoCN
    {
        private static TipoProductoDALC obj = new TipoProductoDALC();
        public static List<tipo_producto> listarTipoProducto()
        {
            return obj.listarTipoProducto();
        }

        public static tipo_producto getTipoProducto(int id)
        {
            return obj.getTipoProducto(id);
        }

        public static void Agregar(tipo_producto tipo_producto)
        {
            obj.Agregar(tipo_producto);
        }

        public static void editar(tipo_producto tipo_producto)
        {
            obj.editar(tipo_producto);
        }

        public static void eliminar(int id)
        {
            obj.eliminar(id);
        }
    }
}
