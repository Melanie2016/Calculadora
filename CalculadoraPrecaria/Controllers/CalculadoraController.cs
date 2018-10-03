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

        [HttpGet]
        public ActionResult Calcular()
        {


            return View();

        }

        [HttpPost]
        public ActionResult Calcular(Calculadora c)
        {

            calcuService.Sumar(c);

            return View("Resultado",c);

        }


    }
}