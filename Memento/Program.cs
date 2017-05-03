using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico Historico = new Historico();

            Contrato Contrato = new Contrato(DateTime.Now, "Rodrigo", TipoContrato.Novo);
            Historico.Adiciona(Contrato.SalvaEstado());

            Contrato.Avanca();
            Historico.Adiciona(Contrato.SalvaEstado());

            Contrato.Avanca();
            Historico.Adiciona(Contrato.SalvaEstado());

            Contrato.Avanca();
            Historico.Adiciona(Contrato.SalvaEstado());


        }
    }
}
