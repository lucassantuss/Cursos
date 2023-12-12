using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Aula01_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjunto de alunos ordenados
            // SORTED SET no lugar de HASH SET
            // ISet<string> alunos = new HashSet<string>()
            // sobrecarga do construtor -> comparador
            // necessário para ajustar a forma como comparamos
            // ISet<string> alunos = new SortedSet<string>()
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
                Console.WriteLine(aluno);

            // Árvore Binária ordenada por valores
            // Somente valores no SET

            // Operações com conjuntos
            ISet<string> outroConjunto = new HashSet<string>();

            // este conjunto está contido no outro? - IsSubsetOf
            alunos.IsSubsetOf(outroConjunto);

            // este conjunto contém o outro? - IsSupersetOf
            alunos.IsSupersetOf(outroConjunto);

            // os conjuntos contém os mesmos elementos? - SetEquals
            alunos.SetEquals(outroConjunto);

            // subtrai os elementos da outra coleção que também estão nessa coleção - ExceptWith
            alunos.ExceptWith(outroConjunto);

            // interseccção entre os dois conjuntos - IntersectWith
            alunos.IntersectWith(outroConjunto);

            // somente em um ou outro conjunto - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            // união de conjuntos - UnionWith
            alunos.UnionWith(outroConjunto);
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}