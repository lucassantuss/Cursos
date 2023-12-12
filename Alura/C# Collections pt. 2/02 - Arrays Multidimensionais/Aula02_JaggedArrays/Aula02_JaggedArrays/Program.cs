using System;

namespace Aula02_JaggedArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // JAGGED ARRAYS
            // ARRAY DENTEADO = ARRAY SERRILHADO
            // ARRAY DE ARRAYS
            // quantidade diferente de elementos por coluna
            // linhas com tamanhos diferentes

            // família 1: Família Flitstones
            // família 2: Família Simpsons
            // família 3: Família Dona Florinda

            // declaração do jagged array
            string[][] familias = new string[3][];
            //{
            //    { "Fred", "Wilma", "Pedrita" },
            //    { "Homer", "Marge", "Lisa", "Bart", "Maggie" },
            //    { "Florinda", "Kiko" }
            //};

            // preenchendo valores do jagged array
            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            //foreach (var pessoa in familias)
            //    Console.WriteLine(pessoa);

            foreach (var familia in familias)
                Console.WriteLine(string.Join(",", familia));
        }
    }
}