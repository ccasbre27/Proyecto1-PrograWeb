using P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Beginner()
        {
            ClaseSurf clase = new ClaseSurf()
            {
                Nombre = "Begineer",
                PrecioBase = 150,
                Descuento = 15,
                DuracionClase = 3,
                ListaCronograma = new List<Cronograma>()
                {
                    new Cronograma()
                    {
                        Id = "precioNormal",
                        Nombre = "Lunes a Jueves",
                        Descuento = false
                    },
                    new Cronograma()
                    {
                        Id = "precioDescuento",
                        Nombre = "Miércoles a Sábado",
                        Descuento = true
                    }
                },
                ListaDias = new List<Dia>()
                {
                    new Dia()
                    {
                        Id = 1,
                        Descripcion = "La clase será fuera del agua se explicará cómo funciona la tabla.",
                        ImagenURL = "tabla.jpg"
                    },
                     new Dia()
                    {
                        Id = 2,
                        Descripcion = "la clase será teórica y práctica, explicarán sobre corrientes y sobre el manejo de las mismas.",
                        ImagenURL = "corrientes.jpg"
                    },
                      new Dia()
                    {
                        Id = 3,
                        Descripcion = "la clase será 100 % en el agua con olas categoría 1.",
                        ImagenURL = "ola-1.jpg"
                    },
                       new Dia()
                    {
                        Id = 4,
                        Descripcion = "la clase será 100% en el agua con olas categoría 2.",
                        ImagenURL = "ola-2.jpg"
                    }
                }
            };


            return View(clase);
            
        }

        public ActionResult Medium()
        {
            ClaseSurf clase = new ClaseSurf()
            {
                Nombre = "Medium",
                PrecioBase = 200,
                Descuento = 10,
                DuracionClase = 2,
                ListaCronograma = new List<Cronograma>()
                {
                    new Cronograma()
                    {
                        Id = "precioDescuento",
                        Nombre = "Martes a Jueves",
                        Descuento = true
                    },
                    new Cronograma()
                    {
                        Id = "precioNormal",
                        Nombre = "Viernes a Domingo",
                        Descuento = false
                    }
                },
                ListaDias = new List<Dia>()
                {
                    new Dia()
                    {
                        Id = 1,
                        Descripcion = "La clase será fuera del agua se explicará cómo salir de corrientes tipo 3.",
                        ImagenURL = "corrientes.jpg"
                    },
                     new Dia()
                    {
                        Id = 2,
                        Descripcion = "La clase será 100% práctica con olas categoría 3.",
                        ImagenURL = "ola-3.jpg"
                    },
                      new Dia()
                    {
                        Id = 3,
                        Descripcion = "La clase será 100 % en el agua con olas categoría 4.",
                        ImagenURL = "ola-4.jpg"
                    }
                }
            };


            return View(clase);
        }

        public ActionResult Advanced()
        {


            ClaseSurf clase = new ClaseSurf()
            {
                Nombre = "Advanced",
                PrecioBase = 300,
                Descuento = 10,
                DuracionClase = 2,
                ListaCronograma = new List<Cronograma>()
                {
                    new Cronograma()
                    {
                        Id = "precioNormal",
                        Nombre = "Martes a Viernes",
                        Descuento = false
                    },
                    new Cronograma()
                    {
                        Id = "precioDescuento",
                        Nombre = "Miércoles a Domingo",
                        Descuento = true
                    }
                },
                ListaDias = new List<Dia>()
                {
                    new Dia()
                    {
                        Id = 1,
                        Descripcion = "La clase será fuera del agua se explicará cómo salir de corrientes tipo 4.",
                        ImagenURL = "corrientes.jpg"
                    },
                     new Dia()
                    {
                        Id = 2,
                        Descripcion = "La clase será 100% práctica con olas categoría 5.",
                        ImagenURL = "ola-5.jpg"
                    },
                      new Dia()
                    {
                        Id = 3,
                        Descripcion = "La clase será 100 % en el agua con olas categoría 6.",
                        ImagenURL = "ola-6.jpg"
                    }
                }
            };


            return View(clase);
        }
    }
}