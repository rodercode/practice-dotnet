    namespace pokeapi.Models;
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
     
        // Navigation properties
        public List<PokeType> Types { get; set; }
    }