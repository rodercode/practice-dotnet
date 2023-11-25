using pokeapi.Models;

namespace pokeapi.Services;
    public interface IPokemonService
    {
        List<Pokemon> getAll();
        Pokemon getById(int id);
    }