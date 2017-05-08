using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            var valorEsquerda = esquerda.Avalia();
            var valorDireita = direita.Avalia();
            return valorEsquerda / valorDireita;

        }
    }
}
