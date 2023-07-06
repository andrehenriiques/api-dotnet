using System;
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

public class SessoesProfile : Profile
{
    public SessoesProfile()
    {
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<Sessao, ReadSessaoDto>();
    }

}

