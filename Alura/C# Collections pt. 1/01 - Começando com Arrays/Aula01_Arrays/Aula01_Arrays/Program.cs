using System;

namespace Aula01_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array's
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Declaração do Array
            //string[] aulas = new string[]
            //{
            //    aulaIntro, 
            //    aulaModelando, 
            //    aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);

            Console.WriteLine();
            imprimir(aulas);

            Console.WriteLine("\nPrimeiro elemento: " + aulas[0]);
            Console.WriteLine("Último elemento: " + aulas[aulas.Length - 1]);

            Console.WriteLine();
            aulaIntro = "Trabalhando com Arrays";
            imprimir(aulas);

            Console.WriteLine();
            aulas[0] = "Trabalhando com Arrays";
            imprimir(aulas);

            // Procurar o indice no Array onde está o objeto selecionado -> IndexOf
            Console.WriteLine("\nAula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine("Último indice encontrado desse objeto: " + Array.LastIndexOf(aulas, aulaModelando));

            // Inverte a ordem dos dados no array (posições)
            Array.Reverse(aulas);
            Console.WriteLine();
            imprimir(aulas);

            // Inverte a ordem denovo dos dados no array (posições) e volta ao estado original
            Array.Reverse(aulas);
            Console.WriteLine();
            imprimir(aulas);

            // Redimensionar o tamanho do Array (de 3 para 2 por exemplo)
            // Perdeu o ultimo valor do array
            Array.Resize(ref aulas, 2);
            Console.WriteLine();
            imprimir(aulas);

            // Voltar para o tamanho 3 (tamanho original)
            // Ultimo elemento ficou null
            Array.Resize(ref aulas, 3);
            Console.WriteLine();
            imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Console.WriteLine();
            imprimir(aulas);

            // Ordenar em ordem alfabética (não dá para voltar depois para o estado original)
            Array.Sort(aulas);
            Console.WriteLine();
            imprimir(aulas);

            // Copiar os dados para outro Array (somente 2 ultimos dados)
            string[] copia = new string[2];

            // array source
            // posição inicial do array source
            // array destino
            // posição inicial do array destino
            // quantidade de itens copiados
            Array.Copy(aulas, 1, copia, 0, 2);
            Console.WriteLine();
            imprimir(copia);

            // Clonar um outro array existente
            // Utilizando cast de object para string[]
            string[] clone = aulas.Clone() as string[];
            Console.WriteLine();
            imprimir(clone);

            // Limpar alguns elementos do Array (2 e 3 elemento)
            // array a ser limpo
            // posição inicial do array
            // quantidade de itens limpados
            Array.Clear(clone, 1, 2);
            Console.WriteLine();
            imprimir(clone);
        }

        private static void imprimir(string[] aulas)
        {
            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}