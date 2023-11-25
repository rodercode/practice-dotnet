using System.Text.Json.Serialization;

namespace pokeapi.Models;
    public class PokeType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int PokemonId { get; set; }
        [JsonIgnore]
        public Pokemon Pokemon { get; set; }
    }