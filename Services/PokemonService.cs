
using pokeapi.Models;
using pokeapi.Repositories;

namespace pokeapi.Services;
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository pokemonRepository;

        public PokemonService(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }

        public List<Pokemon> getAll()
        {
            return pokemonRepository.getAll();
        }
}