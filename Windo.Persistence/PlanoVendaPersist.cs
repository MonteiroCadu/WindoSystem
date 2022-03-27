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
    public class PlanoVendaPersist : IPlanoVendaPersist
    {
        private readonly windo_baseContext contexto;

        public PlanoVendaPersist(windo_baseContext contexto)
        {
            this.contexto = contexto;
        }
        

        public async Task<PlanoVenda?> GetByIdAsync(int id)
        {
            IQueryable<PlanoVenda> query = contexto.PlanoVendas
               .Include(p => p.ValidadeLicencaNavigation)               
               .Where(p => p.Id == id && p.Ativo)
               .AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }
    }
}
