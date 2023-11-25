using Microsoft.AspNetCore.Mvc;
using pokeapi.Models;
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
        public IActionResult GetAll()
        {
            var response = new ApiResponse<List<Pokemon>>
            {
                StatusCode = 200,
                Message = "Success",
                Data = pokemonService.getAll()
            };

            return Ok(response);
        }
    }