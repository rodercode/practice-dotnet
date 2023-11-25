using pokeapi.Models;

namespace pokeapi.Repositories
{
    public interface IPokemonRepository
    {
        List<Pokemon> getAll();     
        Pokemon? getById(int id);   
    }
}