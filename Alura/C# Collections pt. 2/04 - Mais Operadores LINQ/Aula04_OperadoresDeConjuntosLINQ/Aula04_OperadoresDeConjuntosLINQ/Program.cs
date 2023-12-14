using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula04_OperadoresDeConjuntosLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("-> Concatenando duas sequências");
            var consulta = seq1.Concat(seq2);
            Imprimir(consulta);

            Console.WriteLine("-> União de duas sequências");
            var consulta2 = seq1.Union(seq2);
            Imprimir(consulta2);

            Console.WriteLine("-> União de duas sequências com comparador");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            Imprimir(consulta3);

            Console.WriteLine("-> Intersecção de duas sequências");
            var consulta4 = seq1.Intersect(seq2);
            Imprimir(consulta4);

            Console.WriteLine("-> Exceto: elementos de seq1 que não estão em seq2");
            var consulta5 = seq1.Except(seq2);
            Imprimir(consulta5);
        }

        private static void Imprimir(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}