
using AutoMapper;
using pokeapi.Dto;
using pokeapi.Models;
using pokeapi.Repositories;

namespace pokeapi.Services;
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository pokemonRepository;
        private readonly IMapper mapper;

        public PokemonService(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this.pokemonRepository = pokemonRepository;
            this.mapper = mapper;
        }

        public List<PokemonDto> GetAll(string? filterOn, string? filterQuery)
        {
            List<Pokemon> pokemonsDomain = pokemonRepository.GetAll(filterOn, filterQuery);
            return mapper.Map<List<PokemonDto>>(pokemonsDomain);
        }

        public PokemonDto GetById(int id)
        {
            Pokemon? pokemonDomain = pokemonRepository.GetById(id);
            if(pokemonDomain == null)
            {
                throw new Exception("Pokemon not found");
            }
            return mapper.Map<PokemonDto>(pokemonDomain);
        }
}