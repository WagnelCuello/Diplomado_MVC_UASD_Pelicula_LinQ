using Diplomado_MVC_UASD_Pelicula_LinQ_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_UASD_Pelicula_LinQ_Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Pelicula>()
            {
                new Pelicula(){ Titulo="TheGodfather", Director="Francis Ford", AutorPrincipal="Al Pacino", NumAutores=30, Duracion=2,  Estreno=1994 },
                new Pelicula(){ Titulo="The Shaushank", Director="Frank Darabond", AutorPrincipal="Morgan Freeman", NumAutores=15, Duracion=3,  Estreno=1972 },
                new Pelicula(){ Titulo="The Matrix", Director="Lana Wachowski", AutorPrincipal="Keanu Reeves", NumAutores=15, Duracion=2.30m,  Estreno=1999 },
                new Pelicula(){ Titulo="City of God", Director="Fernando Mirelles", AutorPrincipal="Alexandre Rodrigues", NumAutores=10, Duracion=3,  Estreno=2002 },
                new Pelicula(){ Titulo="Star Wars: Episode IV", Director="George Lucas", AutorPrincipal="Harrison Ford", NumAutores=20, Duracion=2.4m,  Estreno=2007 }
            };

            var resultPeliculas = from Pelicula in peliculas
                                  where Pelicula.Titulo.Contains("The")
                                  select Pelicula;

            return View(resultPeliculas);
        }

        public ActionResult Productos()
        {
            var productos = new List<Producto>()
            {
                new Producto(){ Id=1, Descripcion="Arroz", Precio=25 },
                new Producto(){ Id=2, Descripcion="Azucar", Precio=25 },
                new Producto(){ Id=3, Descripcion="Sal", Precio=10 },
                new Producto(){ Id=4, Descripcion="Aji", Precio=12 },
                new Producto(){ Id=4, Descripcion="Cebolla", Precio=50 },
                new Producto(){ Id=5, Descripcion="Habichuela", Precio=30 },
                new Producto(){ Id=6, Descripcion="Lambi", Precio=170 },
                new Producto(){ Id=7, Descripcion="Pescado", Precio=125 },
                new Producto(){ Id=8, Descripcion="Calamar", Precio=250 },
                new Producto(){ Id=9, Descripcion="Aceite", Precio=35 },
                new Producto(){ Id=10, Descripcion="Vinagre", Precio=40 }
            };

            var resultLetraL = from Producto in productos
                                  where Producto.Descripcion.Contains("l")
                                  select Producto;
            var resultLetraC = from Producto in productos
                               where Producto.Descripcion.StartsWith("c")
                               select Producto;
            var resultLetraO = from Producto in productos
                               where Producto.Descripcion.EndsWith("o")
                               select Producto;
            var resultLetraPrecio20 = from Producto in productos
                               where Producto.Precio > 20
                               select Producto;
            var resultLetraPrecio70 = from Producto in productos
                                      where Producto.Precio < 70
                                      select Producto;
            return View(resultLetraL);
        }
    }
}