using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao expressao1 = new Soma(new Numero(10), new Numero(20));
            IExpressao expressao2 = new Subtracao(new Numero(20), new Numero(10));
            IExpressao expressao3 = new Multiplicacao(expressao1, expressao2);
            IExpressao expressao4 = new Divisao(expressao3, new Numero(2));
            IExpressao expressao5 = new RaizQuadrada(expressao4);

            Console.WriteLine(expressao5.Avalia());
        }
    }
}
