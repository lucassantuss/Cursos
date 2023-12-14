using System;
using System.Collections.Generic;

namespace Aula05_Foreach
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var meses = new List<string>
            var meses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro",
            };

            foreach (var mes in meses)
            {
                // não pode modificar a variável de iteração do foreach
                // mes = mes.ToUpper();

                // é gerado um erro se modificar a coleção que está sendo tratada no foreach
                // Collection was modified; enumeration operation may not execute.
                // considerando List<string> meses
                // meses[1] = meses[1].ToUpper();

                // utilizando array não dá erro, porque o laço foreach trabala com array diferente
                // não trabalha com iterador
                // transforma como se fosse num laço for
                meses[1] = meses[1].ToUpper();

                Console.WriteLine(mes);
            }

            // foreach tratando array é nesse modelo a tratativa por debaixo dos panos
            for (int i = 0; i < meses.Length; i++)
            {
                var mes = meses[i];
                // . . . . . . . .
            }

            // Enumerable implementado no método foreach

            // public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
            // {
            //      Gets the element at the current position of the enumerator.
            //      public T Current { get; }

            //      Releases all resources used by the System.Collections.Generic.List`1.Enumerator.
            //      public void Dispose();

            //      Advances the enumerator to the next element of the System.Collections.Generic.List`1.
            //      public bool MoveNext();
            // }
        }
    }
}