using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MensagemParaAdministrador : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemParaAdministrador(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem para o administrador {0}", nome);
        }
    }
}
