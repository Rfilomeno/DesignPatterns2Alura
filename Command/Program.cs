using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDeProcessamento fila = new FilaDeProcessamento();
            Pedido pedido1 = new Pedido("Rodrigo", 100);
            Pedido pedido2 = new Pedido("Claudio", 200);

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new Finaliza(pedido1));

            fila.Executa();
        }
    }
}
