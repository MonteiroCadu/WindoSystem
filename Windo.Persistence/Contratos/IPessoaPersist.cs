using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Dominio;

namespace Windo.Persistence.Contratos
{
    public interface IPessoaPersist
    {

        Task<IList<Pessoa>> GetAllAsync(int top);
        Task<Pessoa?> GetByIdAsync(int id);
        Task<Pessoa?> GetByDocumentoAsync(string documento);
        Task<Pessoa?> GetByEmailAsync(string email);
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<IList<Pessoa>> SearchByEmailAsync(string email);

        Task<IList<Pessoa>> SearchByNomeAsync(string nome);


    }
}
