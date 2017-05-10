using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonServico
    {
        static Servico singleton = new Servico();

        public Servico Instancia {
            get
            {
                return singleton;
            }
        }


    }


}
