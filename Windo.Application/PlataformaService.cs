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
    public class PlataformaService : IPlataformaService
    {
        private readonly IPlataformaPersist plataformaPersist;
        private readonly IMapper mapper;

        public PlataformaService(IPlataformaPersist plataformaPersist, IMapper mapper)
        {
            this.plataformaPersist = plataformaPersist;
            this.mapper = mapper;
        }
        public async Task<IList<PlataformaDto>> GetAllAtivoComPlanoAsync()
        {
            var plataformaModel = await this.plataformaPersist.GetAllAtivoComPlanoAsync();
            var plataformasDto = this.mapper.Map<IList<PlataformaDto>>(plataformaModel);

            return plataformasDto;
        }

        public async Task<PlataformaDto?> GetByIdAsync(int id)
        {
            var plataformaModel = await this.plataformaPersist.GetByIdAsync(id);
            var plataformaDto = this.mapper.Map<PlataformaDto>(plataformaModel);

            return plataformaDto;
        }
    }
}
