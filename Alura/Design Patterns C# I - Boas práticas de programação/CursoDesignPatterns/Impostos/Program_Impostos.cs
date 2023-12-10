using System;

namespace CursoDesignPatterns
{
    class Program_Impostos
    {
        static void Main_Teste(string[] args)
        {
            // Invés de IF, utilizamos a Interface para otimizar o processo
            // Strategy - Padrão de Projeto
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            // Calculando o ICMS
            calculador.RealizaCalculo(orcamento, icms);

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICCC
            calculador.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}