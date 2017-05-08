using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            this.expressao = expressao;
        }

        public int Avalia()
        {
            var Resultado = expressao.Avalia();
            return (int)Math.Sqrt(Resultado);
        }
    }
}
