using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            var valorEsquerda = Esquerda.Avalia();
            var valorDireita = Direita.Avalia();
            return valorEsquerda * valorDireita;
        }
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeMultiplicacao(this);
        }
    }
}
