using pokeapi.Models;

namespace pokeapi.Repositories
{
    public interface IPokemonRepository
    {
        List<Pokemon> GetAll(string? filterOn = null, string? filterQuery = null);     
        Pokemon? GetById(int id);   
    }
}