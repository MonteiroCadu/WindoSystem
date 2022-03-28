using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Dominio;

namespace Windo.Persistence.Contratos
{
    public interface ICorretoraPersist
    {
        Task<IList<Corretora>> GetAllAsync();
    }
}
