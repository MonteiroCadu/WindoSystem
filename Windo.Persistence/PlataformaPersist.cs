
using Microsoft.EntityFrameworkCore;
using Windo.Persistence.Contratos;
using Windo.Persistence.Dominio;

namespace Windo.Persistence
{
    public class PlataformaPersist : IPlataformaPersist
    {
        private readonly windo_baseContext contexto;

        public PlataformaPersist(windo_baseContext contexto)
        {
            this.contexto = contexto;
        }
        public async Task<IList<Plataforma>> GetAllAtivoComPlanoAsync()
        {
             IQueryable<Plataforma> query = contexto.Plataformas                
                .Include(p => p.PlanoVenda)                
                .ThenInclude(p => p.ValidadeLicencaNavigation)
                .Where(p => p.PlanoVenda.Count() > 0 && p.Ativa)                 
                .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<Plataforma?> GetByIdAsync(int id)
        {
            IQueryable<Plataforma> query = contexto.Plataformas
               .Include(p => p.PlanoVenda)
               .ThenInclude(p => p.ValidadeLicencaNavigation)
               .Where(p => p.Id == id)
               .AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }
    }
}
