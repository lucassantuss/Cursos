using System;
using System.Collections.Generic;

namespace Aula01_SortedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            // criando dicionário de alunos
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach(var aluno in alunos)
                Console.WriteLine(aluno);

            // removendo AL
            alunos.Remove("AL");
            // adicionando MO
            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Console.WriteLine();
            foreach (var aluno in alunos)
                Console.WriteLine(aluno);

            // No dictionary foi substituido o item na posição que havia sido removido anteriormente

            // nova coleção: SORTED LIST
            // IDictionary
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            foreach (var item in sorted)
                Console.WriteLine(item);

            // SORTED LIST JÁ ORDENA SOZINHA SEM PRECISAR DEIXAR EXPLICITO
            // Ordena pelas chaves
        }
    }
}