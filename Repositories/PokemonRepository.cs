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
    public List<Pokemon> GetAll(string? filterOn = null, string? filterQuery = null)
    {
        var pokemons = context.Pokemons.
        Include(p => p.Types).
        AsQueryable();

        // Filtering
        if(string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
        {
            if(filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
            {
                pokemons = pokemons.Where(p => p.Name.Contains(filterQuery));
            }
        }
        return pokemons.ToList();
    }
    public Pokemon? GetById(int id)
    {
        return context.Pokemons
            .Include(p => p.Types)
            .FirstOrDefault(p => p.Id == id);            
    }
}