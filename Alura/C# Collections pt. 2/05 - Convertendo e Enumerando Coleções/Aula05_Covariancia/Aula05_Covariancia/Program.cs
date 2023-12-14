using System;
using System.Collections.Generic;

namespace Aula05_Covariancia
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string herda de Object
            Console.WriteLine("-> string para object ?");

            string titulo = "meses";
            object obj = titulo;

            Console.WriteLine(obj);
            Console.WriteLine();

            Console.WriteLine("-> List<string> para List<object> ?");

            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            // não é possível realizar
            // IList<object> listaObj = listaMeses;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-> string[] para object[] ?");
            
            string[] arrayMeses = new string[]{
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses; // COVARIÂNCIA

            Console.WriteLine(arrayObj);
            Console.WriteLine();

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayObj[0] = "PRIMEIRO MÊS";
            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //arrayObj[0] = 12345;
            //foreach (var item in arrayObj)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("-> List<string> para IEnumerable<object> ?");
            IEnumerable<object> enumObj = listaMeses; // COVARIÂNCIA SEGURA devido o OUT no parametro de IEnumerable
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //enumObj[0] = 12345;
        }
    }
}