using Microsoft.EntityFrameworkCore;
using pokeapi.Models;

namespace pokeapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokeType> Types { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Pokemons
            var pokemonList = new List<Pokemon>(){

                new Pokemon(){Id = 1,Name = "Bulbasaur"},
                new Pokemon(){Id = 2, Name = "Charmander"},
                new Pokemon(){ Id = 3, Name = "Squirtle"}
            };

            // Seed pokemons to the database
            modelBuilder.Entity<Pokemon>().HasData(pokemonList);

            
        }
    }
}