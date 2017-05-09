using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class RaizQuadrada : IExpressao
    {
        public IExpressao Expressao { get; private set; }

        public RaizQuadrada(IExpressao expressao)
        {
            this.Expressao = expressao;
        }

        public int Avalia()
        {
            var Resultado = Expressao.Avalia();
            return (int)Math.Sqrt(Resultado);
        }
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeRaizQuadrada(this);
        }
    }
}
