using Microsoft.AspNetCore.Mvc;
using System;

namespace Villamigos.Web.Controllers
{
    public class PruebasController : Controller
    {
        public ContentResult Index()
        {
            string Mensaje = "Bienvenido a Villamigos  " +
                $"Hoy es {DateTime.Today.ToString()}";
            return new ContentResult
            {
                Content = Mensaje
            };
        }

        public ContentResult Html()
        {
            ContentResult resultado = new ContentResult
            {
                Content = "<h1>Bienvenido a Villamigos</h1>",
                ContentType = "html"
            };
            return resultado;
        }

        public JsonResult DatosJson()
        {
            var datos = new { Id = 1, nombre = "Ana" };
            return new JsonResult(datos);
        }


        public ContentResult Prohibido()
        {
            ContentResult resultado = new ContentResult
            {
                StatusCode = 403,
            };
            return resultado;
        }

        public ContentResult MostrarCodigo(string id)
        {
            return new ContentResult
            {
                Content = $"Codigo recibido:  {id}"
            };
        }

        public ContentResult ProcesarNombre (string nombre)
        {
            return new ContentResult
            {
                Content = $"Hola: {nombre}  tu nombre tiene " +
                $"{nombre.Length}  letras"
            };
        }

        public ContentResult PrecioNeto(decimal Precio, decimal descuento)
        {
            decimal montoDescuento = Precio * descuento / 100;
            decimal neto = Precio - descuento;
            return new ContentResult
            {
                Content = $"Bruto:  {Precio}  Descuento: {montoDescuento} " +
                $" Neto: {neto}"
            };
        }

        public ViewResult Bienvenida()
        {
            ViewBag.framework = AppContext.TargetFrameworkName;
            ViewBag.Hoy = DateTime.Today;
           
            return View();
        }

        public ViewResult MasaCorporal(decimal? peso, decimal? altura)
        {
            if(peso != null && altura != null)
            {
                ViewBag.Indice = peso.Value /
                    (altura.Value * altura.Value);
            }
            return View();
        }


    }


}
