using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo (Orcamento orcamento, Imposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);

            //// evita problema se a variavel imposto for null com .Equals depois
            //if ("ICMS".Equals(imposto))
            //{
            //    double icms = new ICMS().CalculaICMS(orcamento);
            //    Console.WriteLine(icms);
            //}
        }
    }
}