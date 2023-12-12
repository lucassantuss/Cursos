﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula04_OperadoresLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            // 1. Pegar o primeiro trimestre
            // Take
            var consulta = meses.Take(3);
            Imprimir(consulta);

            // 2. Pegar os meses depois do primeiro trimestre
            // Skip
            var consulta2 = meses.Skip(3);
            Imprimir(consulta2);

            // 3. Pegar os meses do terceiro trimestre
            // Skip e depois Take
            var consulta3 = meses.Skip(6).Take(3);
            Imprimir(consulta3);

            // 4. Pegar os meses até que o mês comece com a letra 'S'
            // TakeWhile -> pegue enquanto...
            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            Imprimir(consulta4);

            // 5. Pular os meses até que o mês comece com a letra 'S'
            // SkipWhile -> pule enquanto...
            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            Imprimir(consulta5);
        }

        private static void Imprimir(IEnumerable<Mes> consulta)
        {
            foreach (var item in consulta)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }

    class Mes : IComparable
    {
        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public override string ToString()
        {
            return $"[{Nome} - {Dias}]";
        }

        public int CompareTo(object obj)
        {
            Mes outro = obj as Mes;

            return Nome.CompareTo(outro.Nome);
        }
    }
}