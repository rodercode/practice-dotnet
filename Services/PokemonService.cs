
using pokeapi.Repositories;

namespace pokeapi.Services;
    public class PokemonService
    {
        private readonly IPokemonRepository pokemonRepository;

        public PokemonService(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }   
    }