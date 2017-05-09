using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IExpressao
    {
        int Avalia();

        void Aceita(IVisitor visitor);
    }
}
