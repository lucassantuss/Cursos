using System;
using System.Collections.Generic;

namespace Aula01_SortedDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SORTED LIST
            IDictionary<string, Aluno> sortedList = new SortedList<string, Aluno>();
            sortedList.Add("VT", new Aluno("Vanessa", 34672));
            sortedList.Add("AL", new Aluno("Ana", 5617));
            sortedList.Add("RN", new Aluno("Rafael", 17645));
            sortedList.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sortedList)
                Console.WriteLine(item);

            // nova coleção: SORTED DICTIONARY
            // também é um dicionário ordenado
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            foreach (var item in sorted)
                Console.WriteLine(item);

            // A diferença entre o SortedList e SortedDictionary se dá mais pela implementação interna de como é tratado
            // Utiliza KeyCollection e ValueCollection ao invés de IList
            // Utiliza ordenação por árvore
            // Árvore binária
            // Estruturas diferentes para o mesmo propósito
            // SortedDictionary é mais rápido
        }
    }
}