using Microsoft.AspNetCore.Mvc;
using pokeapi.Services;

namespace pokeapi.Controllers;
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
        
    }