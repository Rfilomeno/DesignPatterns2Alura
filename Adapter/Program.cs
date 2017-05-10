using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente()
            {
                Nome = "Rodrigo",
                Endereco = "Av. Rio Branco, 156",
                DataNascimento = DateTime.Now.ToString("dd/MM/yyyy")
            };

            string xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
        }
    }
}
