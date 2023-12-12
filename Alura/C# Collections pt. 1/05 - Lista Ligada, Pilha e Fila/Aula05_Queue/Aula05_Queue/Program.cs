using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula05_Queue
{
    public class Program
    {
        // FILA (Queue)
        // O primeiro que entra é o primeiro que sai
        // O último que entra é o último que sai
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("van");
            Enfileirar("Kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            // verificar se a fila não está vazia
            if (pedagio.Any())
            {
                // PEEK retorna o próximo elemento da fila, sem remover ele
                if (pedagio.Peek() == "guincho")
                    Console.WriteLine("guincho está fazendo pagamento..");

                // Desenfileirar -> Dequeue
                string veiculo = pedagio.Dequeue();

                // Saiu veículo
                Console.WriteLine($"Saiu da Fila: {veiculo}");

                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            // Enfileirar -> Enqueue
            pedagio.Enqueue(veiculo);

            // Entrou veículo
            Console.WriteLine($"Entrou na fila: {veiculo}");

            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine();
            Console.WriteLine("FILA: ");

            foreach (var v in pedagio)
                Console.WriteLine(v);

            Console.WriteLine();
        }
    }
}