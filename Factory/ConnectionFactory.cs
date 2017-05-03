using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection;
            conexao.ConnectionString = "String De Coneccao";
            conexao.Open();
            return conexao;

        }
    }
}
