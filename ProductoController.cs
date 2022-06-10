using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace WebAppBar.Controllers
{
    public class ProductoController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add(Models.Request.ProductoRequest model)

        {
            using (Models.BarDbEntities db = new Models.BarDbEntities())

        {
        var oProducto = new Models.Producto();
                oProducto.nomProd= model.Nombre;
                oProducto.descripcion = model.Descripcion;
                oProducto.precio = model.Precio;
                oProducto.cantidad = model.Cantidad;
                oProducto.estado = model.Estado;

                db.Producto.Add(oProducto);
                db.SaveChanges();
            }
            return Ok("Hecho");
        }
        
    }
}