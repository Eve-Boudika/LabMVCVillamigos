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

    }


}
