
using Windo.Application.Dtos;

namespace Windo.Application.Contratos
{
    public interface IPlanoVendaService
    {
        Task<PlanoVendaDto?> GetByIdAsync(int id);
    }
}
