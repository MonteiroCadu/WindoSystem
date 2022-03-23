using AutoMapper;
using Windo.Persistence.Dominio;
using Windo.Application.Dtos;

namespace Windo.Application.Helpers;

public class ProEventosProfile : Profile
{
    public ProEventosProfile()
    {
        //o uso do ReverseMap() e o mesmo que mapear tbm no sentido contrario
        //CreateMap<EventoDto,Evento>() poise precisamos mapear as duas vias
        //de Evento para EventoDto e de EventoDto para Evento 

        CreateMap<Pessoa, PessoaDto>().ReverseMap();
        CreateMap<LicencaDto,LicencaCliente>().ReverseMap();
        CreateMap<Plataforma, PlataformaDto>().ReverseMap();        
    }
}

