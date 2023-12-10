using CursoDesignPatterns.Impostos;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chain of Responsability (Cadeia de responsabilidade)
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Impostos.Item("CANETA", 250));
            orcamento.AdicionaItem(new Impostos.Item("LAPIS", 250));
            orcamento.AdicionaItem(new Impostos.Item("GELADEIRA", 250));
            orcamento.AdicionaItem(new Impostos.Item("FOGAO", 250));
            orcamento.AdicionaItem(new Impostos.Item("MICROONDAS", 250));
            orcamento.AdicionaItem(new Impostos.Item("XBOX", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}