using Microsoft.EntityFrameworkCore;
using pokeapi.Models;

namespace pokeapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokeType> Types { get; set; }        
    }
}