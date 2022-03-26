
using Windo.Application.Dtos;

namespace Windo.Application.Contratos
{
    public interface IPessoaService
    {
        Task<IList<PessoaDto>> GetAllAsync(int top);
        Task<PessoaDto?> GetByIdAsync(int id);
        Task<IList<PessoaDto>> SearchByNomeOrEmailAsync(string nomeOrEmail);
        Task<PessoaDto?> save(PessoaDto pessoaDto);
    }
}
