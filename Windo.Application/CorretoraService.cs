using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Application.Contratos;
using Windo.Application.Dtos;
using Windo.Persistence.Contratos;

namespace Windo.Application
{
    public class CorretoraService : ICorretoraService
    {
        private readonly ICorretoraPersist corretoraPersist;
        private readonly IMapper mapper;

        public CorretoraService(ICorretoraPersist corretoraPersist, IMapper mapper)
        {
            this.corretoraPersist = corretoraPersist;
            this.mapper = mapper;
        }
        public async Task<IList<CorretoraDto>> GetAllAsync()
        {
            var corretoraModel = await this.corretoraPersist.GetAllAsync();
            var corretoraDto = this.mapper.Map<IList<CorretoraDto>>(corretoraModel);

            return corretoraDto;
        }
    }
}
