using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pokeapi.Models
{
    public class PokeType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int PokemonId { get; set; }
        [JsonIgnore]
        public Pokemon Pokemon { get; set; }
    }
}