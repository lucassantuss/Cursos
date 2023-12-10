using System;

namespace Aula04_Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            // criando o método matricula na classe Curso..
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados");

            // alterar o toString da classe que está sendo chamada (ALUNO)
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();
            // verificar se o aluno está matriculado..
            Console.WriteLine($"O aluno {a1.Nome} está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            // instanciando novo aluno
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine();
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

            // comparando a1 e tonini
            Console.WriteLine();
            Console.WriteLine("a1 == a tonini?");
            Console.WriteLine(a1 == tonini);

            // verificando igualdade
            Console.WriteLine();
            Console.WriteLine("a1 é equals a tonini?");
            Console.WriteLine(a1.Equals(tonini));
            // False -> antes de implementar equals
            // True -> depois de implementar equals
            // São diferentes.. precisamos implementar/sobrescrever Equals()

            // limpando o console
            Console.Clear();

            // buscar aluno matriculado por numero de matricula
            // "Quem é o aluno com matricula 5617?"
            Console.WriteLine("Quem é o aluno com matrícula 5617?");
            // Método criado de busca por numero da matricula..
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine("aluno5617 -> " + aluno5617);

            // Porém a busca pode ser mais eficiente
            // Com dicionários, é permitido associar uma chave (no caso, a matricula)
            // a um valor (aluno)

            // Quem é o aluno 5618?
            Console.WriteLine();
            Console.WriteLine("Quem é o aluno 5618?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));
            // gerou uma exceção, adicionado um tratamento do erro..

            // e se a gente tentar add no dictionary outro aluno com a mesma chave 5617?
            // CHAVE ÚNICA
            // Não pode adicionar 2 itens com a mesma chave
            Aluno fabio = new Aluno("Fábio Gushiken", 5617);
            // csharpColecoes.Matricula(fabio);

            // e se quisermos trocar o aluno que tem a mesma chave?
            csharpColecoes.SubstituiAluno(fabio);

            // aluno substituido..
            Console.WriteLine();
            Console.WriteLine("Quem é o aluno 5617 agora?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));
        }
    }
}