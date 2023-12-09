namespace pokeapi.Dto;
    public class PokemonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PokeTypeDto> Types { get; set; }
    }