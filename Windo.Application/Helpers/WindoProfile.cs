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
        CreateMap<LicencaCliente,LicencaDto>().ReverseMap();
        CreateMap<Plataforma, PlataformaDto>().ReverseMap();
        CreateMap<TempoVencimentoLicenca, TempoVencimentoLicencaDto>().ReverseMap();
        CreateMap<PlanoVenda, PlanoVendaDto>().ReverseMap();
        CreateMap<HistoricoLicenca, HistoricoLicencaDto>().ReverseMap();
        CreateMap<Robo, RoboDto>().ReverseMap();
        CreateMap<TempoVencimentoLicenca, TempoVencimentoLicencaDto>().ReverseMap();
        CreateMap<TipoHistoricoLicenca, TipoHistoricoLicencaDto>().ReverseMap();

    }
}

