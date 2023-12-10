using System;
using System.Collections.Generic;

namespace Aula02_ListsReadOnly
{
    public class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");

            // Code Smell -> Sujeira no código, precisa chamar um método da classe Curso
            // Pra não deixar adicionar por fora a propriedade da classe sem permissões
            // Propriedade exposta para manipulação externa

            // csharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21));

            // Tratativa de erro funcionou
            // Exibiu "Collection is read-only."

            // Para isso, precisamos encapsular o método de adicionar para dentro da classe Curso
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

            // Com essa funcionalidade, a opção adicionar está protegida de ser adicionada externamente
            // Controle da Classe Curso nesse momento

            Imprimir(csharpColecoes.Aulas);

            // Adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));
            Imprimir(csharpColecoes.Aulas);

            // Ordenar a lista de aulas
            //csharpColecoes.Aulas.Sort();

            // copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            // ordenar a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            // Totalizar o tempo do curso
            Console.WriteLine();
            Console.WriteLine("Tempo total do curso: " + csharpColecoes.TempoTotal + " minutos");

            Console.WriteLine();
            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}