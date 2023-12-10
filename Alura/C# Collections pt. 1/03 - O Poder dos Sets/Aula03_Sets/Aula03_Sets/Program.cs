using System;
using System.Collections.Generic;

namespace Aula03_Sets
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sets = Conjuntos
            // Duas propriedades do SET
            // 1. Não permite duplicidade
            // 2. Os elementos não são mantidos em ordem específica

            // declarando set dos alunos
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
        }
    }
}