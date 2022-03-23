using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Contratos;

namespace Windo.Persistence
{

    public class ConectionFactory : IConectionFactory
    {
        private readonly string strConection = "Server=windobase.database.windows.net;Database=windo_base;User Id=windo;Password=M8t2d.au;";



        SqlConnection IConectionFactory.getConection()
        {
            return new SqlConnection(this.strConection);
        }
    }
}
