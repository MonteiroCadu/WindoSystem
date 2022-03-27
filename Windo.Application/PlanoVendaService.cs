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
    public class PlanoVendaService : IPlanoVendaService
    {
        private readonly IPlanoVendaPersist planoVendaPersist;
        private readonly IMapper mapper;

        public PlanoVendaService(IPlanoVendaPersist planoVendaPersist, IMapper mapper)
        {
            this.planoVendaPersist = planoVendaPersist;
            this.mapper = mapper;
        }
        public async Task<PlanoVendaDto?> GetByIdAsync(int id)
        {
            var planoVendaModel = await this.planoVendaPersist.GetByIdAsync(id);
            var planoVendaDto = this.mapper.Map<PlanoVendaDto>(planoVendaModel);

            return planoVendaDto;
        }
    }
}
