using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TiendaVestir.Controllers
{
    public class TipoProductoController : Controller
    {
        // GET: TipoProducto
        public ActionResult Index()
        {
            var listTipoProducto = TipoProductoCN.listarTipoProducto();
            return View(listTipoProducto);
        }

        public ActionResult Details(int id)
        {
            var tipo_producto = TipoProductoCN.getTipoProducto(id);
            return View(tipo_producto);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tipo_producto tipo_producto)
        {
            try
            {
                TipoProductoCN.Agregar(tipo_producto);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "ocurrió un error al guardar el tipo de producto"+ex.Message);
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var tipo_producto = TipoProductoCN.getTipoProducto(id);
            return View(tipo_producto);
        }

        [HttpPost]
        public ActionResult Edit(tipo_producto tipo_producto)
        {
            if(tipo_producto.nombre == null)
            {
                ModelState.AddModelError("", "Debe ingresar un Nombre de Tipo de Producto.");
                return View(tipo_producto);
            }
            try
            {
                TipoProductoCN.editar(tipo_producto);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "ocurrió un error al editar el tipo de producto" + ex.Message);
                return View(); ;
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var tipo_producto = TipoProductoCN.getTipoProducto(id.Value);
            return View(tipo_producto);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                TipoProductoCN.eliminar(id);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "ocurrió un error al eliminar el tipo de producto" + ex.Message);
                return View(); ;
            }
        }
    }
}