using Microsoft.EntityFrameworkCore;
using pokeapi.Data;
using pokeapi.Models;

namespace pokeapi.Repositories;
public class PokemonRepository : IPokemonRepository
{
    private readonly DataContext context;
    public PokemonRepository(DataContext context)
    {
        this.context = context;
    }
    public List<Pokemon> getAll()
    {
        return context.Pokemons.ToList();
    }

    public Pokemon? getById(int id)
    {
        return context.Pokemons
        .Include(p => p.Types)
        .FirstOrDefault(p => p.Id == id);
    }

}