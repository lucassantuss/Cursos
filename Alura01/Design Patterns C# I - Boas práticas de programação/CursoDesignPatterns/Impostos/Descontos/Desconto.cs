using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos.Descontos
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);

        Desconto Proximo { get; set; }
    }
}