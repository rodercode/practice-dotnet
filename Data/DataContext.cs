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
                new Pokemon(){Id = 1, Name = "Bulbasaur"},
                new Pokemon(){Id = 2, Name = "Charmander"},
                new Pokemon(){Id = 3, Name = "Squirtle"}
            };
            
            // Seed pokemons to the database
            modelBuilder.Entity<Pokemon>().HasData(pokemonList);

            // Seed data for Trainers
            var trainerList = new List<Trainer>(){
                new Trainer(){Id = 1, FirstName = "Marcus", LastName="Groth", Age = 23, Gender = "Male"},
                new Trainer(){Id = 2, FirstName = "Holly", LastName = "Branson", Age = 40, Gender = "Female"},                       
            };
            
            // Seed trainers to the database
            modelBuilder.Entity<Trainer>().HasData(trainerList);

            // Seed data for Type
            var typeList = new List<PokeType>(){
                new PokeType(){Id = 1, Name = "Grass", PokemonId = 1},
                new PokeType(){Id = 2, Name = "Poison", PokemonId = 1},
                new PokeType(){Id = 3, Name = "Fire", PokemonId = 2},
                new PokeType(){Id = 4, Name = "Water", PokemonId = 3},
            };

            // Seed type to the database
            modelBuilder.Entity<PokeType>().HasData(typeList);
        }
    }
}