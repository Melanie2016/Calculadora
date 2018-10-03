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

        public int Restar(Calculadora c)
        {
            c.resultado = c.primerNumero - c.segundoNumero;
            return c.resultado;
        }

        public int Multiplicar(Calculadora c)
        {
            c.resultado = c.primerNumero * c.segundoNumero;
            return c.resultado;
        }

        public int Dividir(Calculadora c)
        {
            if(c.segundoNumero.Equals(0))
            {
                c.error = 1;

                return c.error;
            }
            else
            {
                c.resultado = c.primerNumero / c.segundoNumero;

                return c.resultado;
            }
            
        }

    }
}