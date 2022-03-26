using Windo.Persistence.Dominio;

namespace Windo.Persistence.Contratos
{
    public interface IPlataformaPersist
    {
        Task<IList<Plataforma>> GetAllAtivoComPlanoAsync();
        Task<Plataforma?> GetByIdAsync(int id);
    }
}
