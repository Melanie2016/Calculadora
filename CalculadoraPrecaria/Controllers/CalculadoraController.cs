using CalculadoraPrecaria.Models;
using System.Web.Mvc;

namespace CalculadoraPrecaria.Controllers
{
    public class CalculadoraController : Controller
    {

        CalculadoraService calcuService = new CalculadoraService();


        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Operaciones()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Sumar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sumar(Calculadora c)
        {
            calcuService.Sumar(c);
            return View("Resultado", c);
        }



        [HttpGet]
        public ActionResult Restar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Restar(Calculadora c)
        {
            calcuService.Restar(c);
            return View("Resultado", c);
        }



        [HttpGet]
        public ActionResult Multiplicar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Multiplicar(Calculadora c)
        {
            calcuService.Multiplicar(c);
            return View("Resultado", c);
        }



        [HttpGet]
        public ActionResult Dividir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dividir(Calculadora c)
        {
            calcuService.Dividir(c);

            if (c.error == 1)
            {
                TempData["Error1"] = "No se puede dividir por cero !";
                return View("Resultado", c);
            }
            else 
            {
                
                return View("Resultado", c);
            }
        }










    }
}