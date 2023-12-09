    using System.Text.Json.Serialization;

    namespace pokeapi.Models;
    public class PokeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }