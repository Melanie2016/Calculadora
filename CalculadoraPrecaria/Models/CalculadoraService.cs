using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraPrecaria.Models
{
    public class CalculadoraService
    {


        public int Sumar(Calculadora c)
        {
            c.resultado = c.primerNumero + c.segundoNumero;
            return c.resultado;
        }



    }
}