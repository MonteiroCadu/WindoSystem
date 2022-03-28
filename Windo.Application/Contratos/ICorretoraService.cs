using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Application.Dtos;

namespace Windo.Application.Contratos
{
    public interface ICorretoraService
    {
        Task<IList<CorretoraDto>> GetAllAsync();
    }
}
