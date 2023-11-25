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
            return Ok(new ApiResponse<List<Pokemon>>
            {
                StatusCode = 200,
                Message = "Success",
                Data = pokemonService.getAll()
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new ApiResponse<Pokemon>
            {
                StatusCode = 200,
                Message = "Retrieved pokemon by id successfully",
                Data = pokemonService.getById(id)
            });
        }
    }