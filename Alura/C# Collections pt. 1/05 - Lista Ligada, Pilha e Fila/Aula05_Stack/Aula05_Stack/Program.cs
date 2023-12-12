using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula05_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tratando um problema real da navegação de um navegador WEB
            // Botão voltar que mantém o histórico das páginas anteriores
            // Botão avançar que mantém o histórico das páginas seguintes

            // PILHA (Stack)
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
        }
    }

    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Páginal atual: " + atual);
            }
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Páginal atual: " + atual);
            }
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Páginal atual: " + atual);
        }
    }
}