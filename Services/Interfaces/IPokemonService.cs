using pokeapi.Dto;
using pokeapi.Models;

namespace pokeapi.Services;
    public interface IPokemonService
    {
        List<PokemonDto> GetAll(string? filterOn, string? filterQu);
        PokemonDto GetById(int id);
    }