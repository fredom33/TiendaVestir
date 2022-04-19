using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class TipoProductoDALC
    {
        public List<tipo_producto> listarTipoProducto() 
        {
            using(var db = new tienda_vestirEntities())
            {
                return db.tipo_producto.ToList();
            }
        }

        public tipo_producto getTipoProducto(int id)
        {
            using (var db = new tienda_vestirEntities())
            {
                //db.tipo_producto.Where(t => t.id == id).FirstOrDefault();
                return db.tipo_producto.Find(id);
            }
        }
        public void Agregar(tipo_producto tipo_producto)
        {
            using(var db = new tienda_vestirEntities())
            {
                db.tipo_producto.Add(tipo_producto);
                db.SaveChanges();
            }
        }

        public void editar(tipo_producto tipo_producto)
        {
            using (var db = new tienda_vestirEntities())
            {
                var existe = db.tipo_producto.Count(p => p.id == tipo_producto.id) > 0;
                if (existe)
                {
                    db.Entry(tipo_producto).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void eliminar(int id)
        {
            using(var db = new tienda_vestirEntities())
            {
                var tipo_producto = db.tipo_producto.Find(id);
                db.tipo_producto.Remove(tipo_producto);
                db.SaveChanges();
            }
        }
    }
}
