using Api_Cinex.DTOs;
using Api_Cinex.Entidades;
using AutoMapper;

namespace Api_Cinex.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCrearDto, Genero>();
            CreateMap<Actor, ActorDTO>().ReverseMap();
            CreateMap<ActorCrearDTO, Actor>();
        }
    }
}
