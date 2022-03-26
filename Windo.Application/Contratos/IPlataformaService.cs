using Windo.Application.Dtos;

namespace Windo.Application.Contratos
{
    public interface IPlataformaService
    {
        Task<IList<PlataformaDto>> GetAllAtivoComPlanoAsync();
        Task<PlataformaDto?> GetByIdAsync(int id);
    }
}
