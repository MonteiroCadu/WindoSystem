using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Application.Contratos;
using Windo.Persistence.Contratos;
using Windo.Persistence.Dominio;
using Windo.Application.Dtos;
using AutoMapper;

namespace Windo.Application
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaPersist pessoaPersist;
        private readonly IMapper mapper;

        public PessoaService(IPessoaPersist pessoaPersist, IMapper mapper)
        {
            this.pessoaPersist = pessoaPersist;
            this.mapper = mapper;
        }

        

        public async Task<IList<PessoaDto>> GetAllAsync(int top)
        {
            var pessoasModel = await this.pessoaPersist.GetAllAsync(top);
            var pessoasDto = this.mapper.Map<IList<PessoaDto>>(pessoasModel);           

            return pessoasDto;
        }

        public async Task<PessoaDto?> GetByIdAsync(int id)
        {
            var pessoaModel = await this.pessoaPersist.GetByIdAsync(id);
            PessoaDto pessoaDto;

            if (pessoaModel != null)
            {
                pessoaDto = this.mapper.Map<PessoaDto>(pessoaModel);
                return pessoaDto;
            }

            return null;
                
        }

        public async Task<PessoaDto?> save(PessoaDto pessoaDto)
        {
            try
            {
                if (pessoaDto == null) 
                    throw new Exception("Erro no salvamento da pessoa, objeto nulo");

                
                var pessoaModel = this.mapper.Map<Pessoa>(pessoaDto);

                if(pessoaDto.Id == 0) 
                    this.pessoaPersist.Add(pessoaModel);
                else 
                    this.pessoaPersist.Update(pessoaModel);


                if (await this.pessoaPersist.SaveChangesAsync())
                {                    
                    return await this.GetByIdAsync(pessoaModel.Id);
                }
                return null;

            }
            catch (System.Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        /// <summary>
        /// Busca por nome ou parte do nome e tambem buca por email
        /// precisando conter um @ para fazer a busca por email.
        /// </summary>
        /// <param name="nomeOrEmail"></param>
        /// <returns>IList<PessoaDto></returns>
        public async  Task<IList<PessoaDto>> SearchByNomeOrEmailAsync(string nomeOrEmail)
        {
            var pessoasModel = nomeOrEmail.Contains("@") 
                ? await this.pessoaPersist.SearchByEmailAsync(nomeOrEmail)
                : await this.pessoaPersist.SearchByNomeAsync(nomeOrEmail);
            
            var pessoasDto = this.mapper.Map<IList<PessoaDto>>(pessoasModel);
            
            return pessoasDto;
        }

       
    }
}
