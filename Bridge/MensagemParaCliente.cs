using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MensagemParaCliente : IMensagem
    {
        private string Nome;

        public IEnviador Enviador { get; set; }

        public MensagemParaCliente(string nome)
        {
            this.Nome = nome;
        }
        

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem para o Cliente {0}", Nome);
        }
    }
}
