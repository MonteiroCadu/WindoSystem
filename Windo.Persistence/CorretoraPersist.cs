using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Contratos;
using Windo.Persistence.Dominio;

namespace Windo.Persistence
{
    public class CorretoraPersist : ICorretoraPersist
    {
        private readonly windo_baseContext contexto;

        public CorretoraPersist(windo_baseContext contexto)
        {
            this.contexto = contexto;
        }
        public async Task<IList<Corretora>> GetAllAsync()
        {
            IQueryable<Corretora> query = contexto.Corretoras              
               .OrderBy(x => x.Nome)
               .AsNoTracking();

            return await query.ToListAsync();
        }
    }
}
