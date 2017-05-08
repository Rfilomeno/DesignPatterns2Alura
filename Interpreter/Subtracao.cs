using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Subtracao : IExpressao
    {
        private IExpressao direita;
        private IExpressao esquerda;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            var valorEsquerda = esquerda.Avalia();
            var valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
