using System;
using System.Collections.Generic;

namespace Aula05_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Imagine uma lista de frutas
            List<string> frutas = new List<string>()
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach (var fruta in frutas)
                Console.WriteLine(fruta);

            // Adicionar um elemento no final de uma lista é rápido
            // Porém inserir no meio da lista exige mais esforço computacional
            // Pois ao inserir ou remover no meio da lista, os valores de cada campo tem que se realocar

            // para isso temos a LINKED LIST
            // -> Elementos não precisam estar em sequência na memória
            // -> Cada elemento é um "nó" que contém um valor
            // -> É armazenado a próxima posição e a anterior
            // -> É utilizado ponteiros

            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");

            // Cada elemento é um nó: LinkedListNode<T>
            Console.WriteLine();
            Console.WriteLine("d4.Value: " + d4.Value);

            // LinkedList não possui único método Add
            // Possui 4 opções:
            // 1. Como primeiro nó - AddFirst
            // 2. Como último nó - AddLast
            // 3. Antes de um nó conhecido - AddBefore
            // 4. Depois de um nó conhecido - AddAfter
            var d2 = dias.AddBefore(d4, "segunda");

            // agora d2 e d4 estão ligados
            // -> d2.Next é igual a d4
            // -> d4.Previous é igual a d2
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sábado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            // imprimir a lista ligada
            Console.WriteLine();
            foreach (var dia in dias)
                Console.WriteLine(dia);

            // LinkedList NÃO DÁ suporte ao acesso de índice: dias[0]
            // por isso podemos fazer um laço foreach mas não um for!
            var quarta = dias.Find("quarta");

            // Para removermos um elemento, podemos tanto remover
            // pelo valor quanto pela referência do LinkedListNode
            // dias.Remove("quarta") ou dias.Remove(d4)
            dias.Remove("quarta");

            Console.WriteLine();
            foreach (var dia in dias)
                Console.WriteLine(dia);
        }
    }
}