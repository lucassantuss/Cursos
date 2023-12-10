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
            Console.WriteLine(string.Join(" , ", alunos));

            // Diferença para uma lista
            // Não tem ordem especifica (cada posição no SET)
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(" , ", alunos));

            // Remover 1 aluno e adicionar outro..
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            // Marcelo foi adicionado na mesma posição que a Ana estava
            Console.WriteLine(string.Join(" , ", alunos));

            // SET não pode adicionar registros duplicados
            // Não mudou nada no conjunto..
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(" , ", alunos));

            // Vantagem do SET
            // É mais rápido para encontrar elementos com HashSet
            // Mais desempenho e escalabilidade
            // CONTRA: Consome mais memória que a List

            // mudar o ISet para ICollection para deixar mais flexível
            // Ordenar com ISet não é permitido, pois não tem o método necessário
            // alunos.Sort();
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(" , ", alunosEmLista));
        }
    }
}