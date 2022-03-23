using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Dominio;
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
