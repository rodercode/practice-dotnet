namespace pokeapi.Models;
    public class Pokemon
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<PokeType> Types { get; set; }
    }