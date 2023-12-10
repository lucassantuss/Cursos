using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula02_Lists
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List's
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Declaração da Lista
            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            // Lista é um array dinâmico (não limitado a quantidade de elementos)
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine();
            Console.WriteLine("A primeira aula é " + aulas[0]);
            // Utilizando o LINQ
            Console.WriteLine("A primeira aula é " + aulas.First());

            Console.WriteLine();
            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            // Utilizando o LINQ
            Console.WriteLine("A última aula é " + aulas.Last());

            // alterando o primeiro valor da lista
            aulas[0] = "Trabalhando com Listas";
            Console.WriteLine();
            Imprimir(aulas);

            Console.WriteLine();
            Console.WriteLine("A primeira aula 'Trabalhando' é: " +
                aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é: " +
                aulas.Last(aula => aula.Contains("Trabalhando")));

            // FirstOrDefault para não dar erro, caso não encontrar um elemento correspondente
            Console.WriteLine();
            Console.WriteLine("A primeira aula 'Conclusão' é: " +
                aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            // Reverte a ordem dos itens
            aulas.Reverse();
            Console.WriteLine();
            Imprimir(aulas);

            aulas.Reverse();
            Console.WriteLine();
            Imprimir(aulas);

            // Remover último elemento
            aulas.RemoveAt(aulas.Count - 1);
            Console.WriteLine();
            Imprimir(aulas);

            aulas.Add("Conclusão");
            Console.WriteLine();
            Imprimir(aulas);

            // Ordenar em ordem alfábetica
            aulas.Sort();
            Console.WriteLine();
            Imprimir(aulas);

            // Copiar para outra lista
            // GetRange para resgatar os valores da lsita
            // Posição Inicial da lista
            // quantidade de itens copiados
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Console.WriteLine();
            Imprimir(copia);

            // Clonar para outra lista (na hora de instanciar)
            List<string> clone = new List<string>(aulas);
            Console.WriteLine();
            Imprimir(clone);

            // Remover 2 últimos elementos do clone
            clone.RemoveRange(clone.Count - 2, 2);
            Console.WriteLine();
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            // Utilizando método anônimo
            // foreach integrado no método
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}