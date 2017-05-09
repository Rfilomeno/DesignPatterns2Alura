using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Finaliza : IComando
    {
        private Pedido pedido;

        public Finaliza(Pedido pedido)
        {
            this.pedido = pedido;

        }

        public void Executa()
        {
            pedido.Finaliza();
            Console.WriteLine("Finalizando pedido de {0}", pedido.Cliente);
        }
    }
}
