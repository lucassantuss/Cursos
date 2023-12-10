using System;
using System.Collections.Generic;

namespace Aula02_ListsOfObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List's of Objects
            var aulaIntro = new Aula("Introdução as Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            // aulas.Add("Conclusão");  -> Tipo de variável errada

            Imprimir(aulas);

            // Ordenar os itens com objetos
            aulas.Sort();
            Imprimir(aulas);

            // Ordenar os itens com objetos por item especifico (Tempo) LINQ
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    // precisa implementar o IComparable para realizar o método Sort
    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        // Configurar o que deve ser comparado no Sort
        public int CompareTo(object obj)
        {
            // necessita de um cast de object para a class Aula
            Aula that = obj as Aula;

            return this.titulo.CompareTo(that.titulo);
        }

        // Override do método toString da classe Object
        public override string ToString()
        {
            return $"[título: {titulo}, tempo: {tempo} minutos]";
        }
    }
}