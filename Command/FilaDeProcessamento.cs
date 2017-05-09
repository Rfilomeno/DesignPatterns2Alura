using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class FilaDeProcessamento
    {
        IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }
        public void Executa()
        {
            foreach (var comando in Comandos)
            {
                comando.Executa();
            }
        }
    }
}
