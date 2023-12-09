using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using pokeapi.Dto;
using pokeapi.Models;
using pokeapi.Models.Domain;
using pokeapi.Models.Dto;

namespace pokeapi.mappings
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Pokemon, PokemonDto>().ReverseMap();
            CreateMap<PokeType, PokeTypeDto>().ReverseMap();
            CreateMap<Pokemon, PokemonCreateDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<City, CityCreateDto>().ReverseMap();
        }
    }
}