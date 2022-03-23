using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Dominio;
using Windo.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace Windo.Persistence
{
    public class PessoaPersist : GeralPersist, IPessoaPersist
    {
        public PessoaPersist(windo_baseContext contexto) : base(contexto)
        {
        }

        public async Task<IList<Pessoa>> GetAllAsync(int top)
        {
            IQueryable<Pessoa> query = _contexto.Pessoas
                .Take(top)
                .OrderByDescending(p => p.Id)
                .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<Pessoa?> GetByDocumentoAsync(string documento)
        {
            IQueryable<Pessoa> query = _contexto.Pessoas
                .Where(p => p.Documento == documento)
                .Include(p => p.LicencaClientes)
                .ThenInclude(lc => lc.PlataformaNavigation)
                .AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Pessoa?> GetByEmailAsync(string email)
        {
            IQueryable<Pessoa> query = _contexto.Pessoas
                .Where(p => p.Email == email)
                .Include(p => p.LicencaClientes)
                .ThenInclude(lc => lc.PlataformaNavigation)
                .AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Pessoa?> GetByIdAsync(int id)
        {
            IQueryable<Pessoa> query = _contexto.Pessoas
                .Where(p => p.Id == id)
                .Include(p => p.LicencaClientes)
                .ThenInclude(lc => lc.PlataformaNavigation)
                .AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IList<Pessoa>> SearchByEmailAsync(string nomeOrEmail)
        {
            IQueryable<Pessoa> query = _contexto.Pessoas
                .Where(p => p.Email.Contains(nomeOrEmail))                
                .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<IList<Pessoa>> SearchByNomeAsync(string nome)
        {
            IQueryable<Pessoa> query = _contexto.Pessoas
                .Where(p => p.NomeCompleto.Contains(nome))
                .AsNoTracking();

            return await query.ToListAsync();
        }
    }
}
