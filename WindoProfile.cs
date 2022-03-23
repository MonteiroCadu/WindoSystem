﻿using AutoMapper;
using Windo.Application.Dtos;
using Windo.Domain;

namespace Windo.Application.Helpers
{
    public class ProEventosProfile : Profile
    {
        public ProEventosProfile()
        {
            //o uso do ReverseMap() e o mesmo que mapear tbm no sentido contrario
            //CreateMap<EventoDto,Evento>() poise precisamos mapear as duas vias
            //de Evento para EventoDto e de EventoDto para Evento 

            //CreateMap<Evento, EventoDto>().ReverseMap();
            //CreateMap<Palestrante, PalestranteDto>().ReverseMap();
            //CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            //CreateMap<Lote, LoteDto>().ReverseMap();
        }
    }
}
